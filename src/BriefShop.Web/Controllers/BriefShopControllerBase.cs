using Abp.AutoMapper;
using Abp.UI;
using Abp.Web.Mvc.Controllers;
using Abp.WebApi.Client;
using BriefShop.Core;
using BriefShop.Regions;
using BriefShop.Regions.Dto;
using BriefShop.Users;
using BriefShop.Users.Dto;
using BriefShop.Web.Framework.Controller;
using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using System.Windows.Threading;

namespace BriefShop.Web.Controllers
{
	/// <summary>
	/// Derive all Controllers from this class.
	/// </summary>
	public abstract class BriefShopControllerBase : AbpController
	{
		//工作上下文
		public WebWorkContext WorkContext = new WebWorkContext();

		protected BriefShopControllerBase()
		{
			LocalizationSourceName = BriefShopConsts.LocalizationSourceName;
		}

		protected virtual void CheckModelState()
		{
			if (!ModelState.IsValid)
			{
				throw new UserFriendlyException(L("FormIsNotValidMessage"));
			}
		}

		protected override void Initialize(RequestContext requestContext)
		{
			base.Initialize(requestContext);
			this.ValidateRequest = false;

			InitWorkContext();
		}

		protected override void OnAuthorization(AuthorizationContext filterContext)
		{
			//不能应用在子方法上
			if (filterContext.IsChildAction)
				return;

			//商城已经关闭
			//if (WorkContext.ShopConfig.IsClosed == 1 && WorkContext.AdminGid == 1 && WorkContext.PageKey != "/account/login" && WorkContext.PageKey != "/account/logout")
			//{
			//	filterContext.Result = PromptView(WorkContext.ShopConfig.CloseReason);
			//	return;
			//}

			//当前时间为禁止访问时间
			//if (ValidateHelper.BetweenPeriod(WorkContext.ShopConfig.BanAccessTime) && WorkContext.AdminGid == 1 && WorkContext.PageKey != "/account/login" && WorkContext.PageKey != "/account/logout")
			//{
			//	filterContext.Result = PromptView("当前时间不能访问本商城");
			//	return;
			//}

			//当用户ip在被禁止的ip列表时
			//if (ValidateHelper.InIPList(WorkContext.IP, WorkContext.ShopConfig.BanAccessIP))
			//{
			//	filterContext.Result = PromptView("您的IP被禁止访问本商城");
			//	return;
			//}

			//当用户ip不在允许的ip列表时
			//if (!string.IsNullOrEmpty(WorkContext.ShopConfig.AllowAccessIP) && !ValidateHelper.InIPList(WorkContext.IP, WorkContext.ShopConfig.AllowAccessIP))
			//{
			//	filterContext.Result = PromptView("您的IP被禁止访问本商城");
			//	return;
			//}

			//当用户IP被禁止时
			//if (BannedIPs.CheckIP(WorkContext.IP))
			//{
			//	filterContext.Result = PromptView("您的IP被禁止访问本商城");
			//	return;
			//}

			//判断目前访问人数是否达到允许的最大人数
			//if (WorkContext.OnlineUserCount > WorkContext.ShopConfig.MaxOnlineCount && WorkContext.AdminGid == 1 && (WorkContext.Controller != "account" && (WorkContext.Action != "login" || WorkContext.Action != "logout")))
			//{
			//	filterContext.Result = PromptView("商城人数达到访问上限, 请稍等一会再访问！");
			//	return;
			//}
		}

		protected override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			//不能应用在子方法上
			if (filterContext.IsChildAction)
				return;
#if DEBUG
			//清空执行的sql语句数目
			//RDBSHelper.ExecuteCount = 0;
			////清空执行的sql语句细节
			//RDBSHelper.ExecuteDetail = string.Empty;
#endif
			//页面开始执行时间
			WorkContext.StartExecuteTime = DateTime.Now;

			//当用户为会员时,更新用户的在线时间
			//if (WorkContext.Uid > 0)
			//	Users.UpdateUserOnlineTime(WorkContext.Uid);

			//更新在线用户
			//Asyn.UpdateOnlineUser(WorkContext.Uid, WorkContext.Sid, WorkContext.NickName, WorkContext.IP, WorkContext.RegionId);
			//更新PV统计
			//if (WorkContext.ShopConfig.UpdatePVStatTimespan != 0)
			//	Asyn.UpdatePVStat(WorkContext.Uid, WorkContext.RegionId, WebHelper.GetBrowserType(), WebHelper.GetOSType());
		}

		protected override void OnActionExecuted(ActionExecutedContext filterContext)
		{
			//不能应用在子方法上
			if (filterContext.IsChildAction)
				return;
#if DEBUG
			//执行的sql语句数目
			//WorkContext.ExecuteCount = RDBSHelper.ExecuteCount;

			//执行的sql语句细节
			//if (RDBSHelper.ExecuteDetail == string.Empty)
			//	WorkContext.ExecuteDetail = "<div style=\"display:block;clear:both;text-align:center;width:100%;margin:5px 0px;\">当前页面没有和数据库的任何交互</div>";
			//else
			//	WorkContext.ExecuteDetail = "<div style=\"display:block;clear:both;text-align:center;width:100%;margin:5px 0px;\">数据查询分析:</div>" + RDBSHelper.ExecuteDetail;
#endif
			//页面执行时间
			WorkContext.ExecuteTime = DateTime.Now.Subtract(WorkContext.StartExecuteTime).TotalMilliseconds / 1000;
		}

		/// <summary>
		/// 初始化工作上下文
		/// </summary>
		protected void InitWorkContext()
		{
			WorkContext.IsHttpAjax = WebHelper.IsAjax();
			WorkContext.IP = WebHelper.GetIP();
			WorkContext.UrlReferrer = WebHelper.GetUrlReferrer();
			WorkContext.Url = WebHelper.GetUrl();

			//获得用户唯一标示符sid
			WorkContext.SessionId = ShopUtils.GetSidCookie();
			if (WorkContext.SessionId.Length == 0)
			{
				//生成sessionid
				WorkContext.SessionId = CommonHelper.GenerateRandomString();
				//将sessionid保存到cookie中
				ShopUtils.SetSidCookie(WorkContext.SessionId);
			}

			User user;

			//获得用户id
			int uid = ShopUtils.GetUidCookie();
			if (uid < 1)//当用户为游客时
			{
				//创建游客
				user = new User().CreateGuest();
			}
			else//当用户为会员时
			{
				//获得保存在cookie中的密码
				string encryptPwd = ShopUtils.GetCookiePassword();
				//防止用户密码被篡改为危险字符
				if (encryptPwd.Length == 0 || !SecureHelper.IsBase64String(encryptPwd))
				{
					//创建游客
					user = new User().CreateGuest();
					encryptPwd = string.Empty;
					ShopUtils.SetUidCookie(-1);
					ShopUtils.SetCookiePassword("");
				}
				WorkContext.EncryptPwd = encryptPwd;
			}

			//设置当前控制器类名
			WorkContext.Controller = RouteData.Values["controller"].ToString().ToLower();
			//设置当前动作方法名
			WorkContext.Action = RouteData.Values["action"].ToString().ToLower();
			WorkContext.PageKey = string.Format("/{0}/{1}", WorkContext.Controller, WorkContext.Action);

			//当前商城主题
			WorkContext.Theme = WorkContext.ShopConfig.PCTheme;
			//设置图片cdn
			WorkContext.ImageCDN = WorkContext.ShopConfig.ImageCDN;
			//设置csscdn
			WorkContext.CSSCDN = WorkContext.ShopConfig.CSSCDN;
			//设置脚本cdn
			WorkContext.ScriptCDN = WorkContext.ShopConfig.ScriptCDN;
			//搜索词
			WorkContext.SearchWord = string.Empty;
		}

		//protected void CheckErrors(IdentityResult identityResult)
		//{
		//	identityResult.CheckErrors(LocalizationManager);
		//}
	}
}