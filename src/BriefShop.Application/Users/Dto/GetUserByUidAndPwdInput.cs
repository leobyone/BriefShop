using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BriefShop.Users.Dto
{
	public class GetUserByUidAndPwdInput
	{
		public int UserId { get; set; }
		public string Password { get; set; }
	}
}
