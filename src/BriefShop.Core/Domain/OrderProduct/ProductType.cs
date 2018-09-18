namespace BriefShop.Core
{
	/// <summary>
	/// 商品类型
	/// </summary>
	public enum ProductType
	{
		/// <summary>
		/// 普通商品
		/// </summary>
		Normal=0,
		/// <summary>
		/// 普通商品赠品
		/// </summary>
		Normal_Send = 1,
		/// <summary>
		/// 套装商品赠品
		/// </summary>
		Suit_Send = 2,
		/// <summary>
		/// 套装商品
		/// </summary>
		Suit = 3,
		/// <summary>
		/// 满赠商品
		/// </summary>
		Full_Send = 4
	}
}
