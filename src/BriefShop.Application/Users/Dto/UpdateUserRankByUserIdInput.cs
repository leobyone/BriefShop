using Abp.AutoMapper;
using BriefShop.Core;

namespace BriefShop.Users.Dto
{
	[AutoMapTo(typeof(User))]
	public class UpdateUserRankByUserIdInput
	{
		public int Id { get; set; }
		public int UserRankId { get; set; }
	}
}
