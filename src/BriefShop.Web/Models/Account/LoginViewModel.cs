using Abp.Auditing;
using System.ComponentModel.DataAnnotations;

namespace BriefShop.Web.Models.Account
{
	public class LoginViewModel
	{
		/// <summary>
		/// 账号名
		/// </summary>
		[Required(AllowEmptyStrings = false, ErrorMessage = "账户名不能为空")]
		//[RegularExpression(@"(select|insert|delete|from|count\(|drop|table|update|truncate|asc\(|mid\(|char\(|xp_cmdshell|exec|master|net|local|group|administrators|user|or|and|-|;|,|\(|\)|\[|\]|\{|\}|%|@|\*|!|\')", ErrorMessage = "账户名不存在")]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "{0}的长度必须大于{2}个字符并小于{1}个字符")]
		public string UsernameOrEmailAddress { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessage = "密码不能为空")]
		[StringLength(32, MinimumLength = 3, ErrorMessage = "{0}的长度必须大于{2}个字符并小于{1}个字符")]
		[DisableAuditing]
		public string Password { get; set; }

		/// <summary>
		/// 是否记住用户
		/// </summary>
		public bool RememberMe { get; set; }

		/// <summary>
		/// 是否启用验证码
		/// </summary>
		//public bool IsVerifyCode { get; set; }
	}
}