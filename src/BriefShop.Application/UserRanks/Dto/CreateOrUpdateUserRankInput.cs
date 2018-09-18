namespace BriefShop.Core.Dtos
{
	/// <summary>
	/// 用户等级表新增和编辑时用Dto
	/// </summary>
	public class CreateOrUpdateUserRankInput
	{
		/// <summary>
		/// 用户等级表编辑Dto
		/// </summary>
		public UserRankEditDto UserRankEditDto { get; set; }
	}
}
