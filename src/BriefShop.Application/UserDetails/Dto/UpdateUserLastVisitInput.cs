using Abp.AutoMapper;
using BriefShop.Core;
using System;

namespace BriefShop.UserDetails.Dto
{
	public class UpdateUserLastVisitInput
	{
		public int UserId { get; set; }
		public DateTime VisitTime { get; set; }
		public string IP { get; set; }
		public int RegionId { get; set; }
	}
}
