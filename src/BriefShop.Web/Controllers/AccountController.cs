using Abp.AutoMapper;
using Abp.Extensions;
using Abp.UI;
using Abp.Web.Models;
using BriefShop.Core;
using BriefShop.LoginFailLogs;
using BriefShop.Regions;
using BriefShop.Regions.Dto;
using BriefShop.UserDetails;
using BriefShop.UserDetails.Dto;
using BriefShop.UserRanks;
using BriefShop.UserRanks.Dto;
using BriefShop.Users;
using BriefShop.Users.Dto;
using BriefShop.Web.Models.Account;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BriefShop.Web.Controllers
{
	public class AccountController : BriefShopControllerBase
	{
		private readonly ILoginFailLogAppService _loginFailLogAppService;
		private readonly IUserAppService _userAppService;
		private readonly IUserRankAppService _userRankAppService;
		private readonly IRegionAppService _regionAppService;
		private readonly IUserDetailAppService _userDetailAppService;

		public AccountController(
			ILoginFailLogAppService loginFailLogAppService, 
			IUserAppService userAppService,
			IUserRankAppService userRankAppService,
			IRegionAppService regionAppService,
			IUserDetailAppService userDetailAppService
			)
		{
			_loginFailLogAppService = loginFailLogAppService;
			_userAppService = userAppService;
			_userRankAppService = userRankAppService;
			_regionAppService = regionAppService;
			_userDetailAppService = userDetailAppService;
		}

		/// <summary>
		/// 登录
		/// </summary>
		/// <returns></returns>
		public async Task<ActionResult> Login(string returnUrl = "")
		{
			returnUrl = NormalizeReturnUrl(returnUrl);

			if (WorkContext.ShopConfig.LoginType == "")
			{
				throw new UserFriendlyException("商城暂时关闭登录功能");
			}

			if (WorkContext.UserId > 0)
			{
				throw new UserFriendlyException("你已经登录，无需重复登录");
			}

			var loginFailTimes = await _loginFailLogAppService.GetLoginFailTimesByIPAsync(WorkContext.IP);

			if (WorkContext.ShopConfig.LoginFailTimes != 0
				&& loginFailTimes > WorkContext.ShopConfig.LoginFailTimes)
			{
				throw new UserFriendlyException("您已经输入错误" + WorkContext.ShopConfig.LoginFailTimes + "次密码，请15分钟后再登录!");
			}

			return View(
				new LoginFormViewModel
				{
					ReturnUrl = returnUrl,
					IsSelfRegistrationAllowed = true
				});
		}

		[HttpPost]
		public virtual async Task<JsonResult> Login(LoginViewModel loginModel, string returnUrl = "")
		{
			returnUrl = NormalizeReturnUrl(returnUrl);

			UserDto userDto = null;

			if (ValidateHelper.IsEmail(loginModel.UsernameOrEmailAddress))//邮箱登录
			{
				if (!BSPConfig.ShopConfig.LoginType.Contains("2"))
				{
					throw new UserFriendlyException("暂时不支持邮箱登录");
				}
				else
				{
					userDto = await _userAppService.GetUserByEmailAsync(loginModel.UsernameOrEmailAddress);

					if (userDto == null)
					{
						throw new UserFriendlyException("邮箱不存在");
					}
				}
			}
			else if (ValidateHelper.IsMobile(loginModel.UsernameOrEmailAddress))
			{
				if (!BSPConfig.ShopConfig.LoginType.Contains("3"))
				{
					throw new UserFriendlyException("暂时不支持手机登录");
				}
				else
				{
					userDto = await _userAppService.GetUserByMobileAsync(loginModel.UsernameOrEmailAddress);

					if (userDto == null)
					{
						throw new UserFriendlyException("手机不存在");
					}
				}
			}
			else
			{
				if (!BSPConfig.ShopConfig.LoginType.Contains("1"))
				{
					throw new UserFriendlyException("暂时不支持用户名登录");
				}
				else
				{
					userDto = await _userAppService.GetUserByNameAsync(loginModel.UsernameOrEmailAddress);

					if (userDto == null)
					{
						throw new UserFriendlyException("用户名不存在");
					}
				}
			}

			if (userDto != null)
			{
				if (SecureHelper.MD5(loginModel.Password + userDto.Salt) != userDto.Password)
				{
				    _loginFailLogAppService.AddLoginFailTimes(WorkContext.IP, DateTime.Now);
					throw new UserFriendlyException("密码不正确");
				}
				else if (userDto.UserRankId == 1)//当用户等级是禁止访问等级时
				{
					if (userDto.LiftBanTime > DateTime.Now)//达到解禁时间
					{
						UserRankDto userRankDto = await _userRankAppService.GetUserRankByCredits(userDto.PayCredits);
						UpdateUserRankByUserIdInput input = new UpdateUserRankByUserIdInput() { Id = userDto.Id, UserRankId = userRankDto.Id };
						await _userAppService.UpdateUserRankByUserIdAsync(input);
						userDto.UserRankId = userRankDto.Id;
					}
					else
					{
						throw new UserFriendlyException("您的账号当前被锁定,不能访问");
					}
				}
			}

			//删除登录失败日志
			await _loginFailLogAppService.DeleteLoginFailLogByIPAsync(CommonHelper.ConvertIPToLong(WorkContext.IP));

			//获取区域信息
			var getIPInput = new GetIPInput();
			getIPInput.IP = WorkContext.IP;
			WorkContext.Region = ObjectMapper.Map<Region>(await _regionAppService.GetRegionByIPAsync(getIPInput));
			WorkContext.RegionId = WorkContext.Region.Id;

			//更新用户最后访问
			UpdateUserLastVisitInput updateUserLastVisitInput = new UpdateUserLastVisitInput();
			updateUserLastVisitInput.UserId = userDto.Id;
			updateUserLastVisitInput.VisitTime = DateTime.Now;
			updateUserLastVisitInput.IP = WorkContext.IP;
			updateUserLastVisitInput.RegionId = WorkContext.RegionId;
			await _userDetailAppService.UpdateUserLastVisit(updateUserLastVisitInput);

			////更新购物车中用户id
			//Carts.UpdateCartUidBySid(partUserInfo.Uid, WorkContext.Sid);

			WorkContext.User = ObjectMapper.Map<User>(userDto);
			//将用户信息写入cookie中
			ShopUtils.SetUserCookie(WorkContext.User, (WorkContext.ShopConfig.IsRemember == 1) ? 30 : -1);

			return Json(new AjaxResponse { TargetUrl = returnUrl });
		}

		/// <summary>
		/// 注册
		/// </summary>
		/// <returns></returns>
		public ActionResult Register()
		{
			return View();
		}

		#region Helpers

		private string NormalizeReturnUrl(string returnUrl, Func<string> defaultValueBuilder = null)
		{
			if (defaultValueBuilder == null)
			{
				defaultValueBuilder = () => Url.Action("Index", "Application");
			}

			if (returnUrl.IsNullOrEmpty())
			{
				return defaultValueBuilder();
			}

			if (Url.IsLocalUrl(returnUrl))
			{
				return returnUrl;
			}

			return defaultValueBuilder();
		}

		#endregion
	}
}