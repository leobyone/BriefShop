using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BriefShop.Core
{
	public class Product: Entity<int>
	{
		public const int MaxNameLength = 200;

		/// <summary>
		/// 商品货号
		/// </summary>
		public string PSN { get; set; }

		/// <summary>
		/// 商品分类id
		/// </summary>
		public int CategoryId { get; set; }

		/// <summary>
		/// 商品品牌id
		/// </summary>
		public int BrandId { get; set; }

		/// <summary>
		/// 商品sku组id
		/// </summary>
		public int SKUGid { get; set; }

		/// <summary>
		/// 商品名称
		/// </summary>
		[Required]
		[MaxLength(MaxNameLength)]
		public string Name { get; set; }

		/// <summary>
		/// 商品商城价
		/// </summary>
		public decimal ShopPrice { get; set; }

		/// <summary>
		/// 商品市场价
		/// </summary>
		public decimal MarketPrice { get; set; }

		/// <summary>
		/// 商品成本价
		/// </summary>
		public decimal CostPrice { get; set; }

		/// <summary>
		/// 0代表上架，1代表下架，2代表回收站
		/// </summary>
		public ProductState State { get; set; }

		/// <summary>
		/// 商品是否精品
		/// </summary>
		public int IsBest { get; set; }

		/// <summary>
		/// 商品是否热销
		/// </summary>
		public int IsHot { get; set; }

		/// <summary>
		/// 商品是否新品
		/// </summary>
		public int IsNew { get; set; }

		/// <summary>
		/// 商品排序
		/// </summary>
		public int DisplayOrder { get; set; }

		/// <summary>
		/// 商品重量
		/// </summary>
		public int Weight { get; set; }

		/// <summary>
		/// 商品展示图片
		/// </summary>
		public string ShowImg { get; set; }

		/// <summary>
		/// 销售数
		/// </summary>
		public int SaleCount { get; set; }

		/// <summary>
		/// 访问数
		/// </summary>
		public int VisitCount { get; set; }

		/// <summary>
		/// 评价数
		/// </summary>
		public int ReviewCount { get; set; }

		/// <summary>
		/// 评价星星1
		/// </summary>
		public int Star1 { get; set; }

		/// <summary>
		/// 评价星星2
		/// </summary>
		public int Star2 { get; set; }

		/// <summary>
		/// 评价星星3
		/// </summary>
		public int Star3 { get; set; }

		/// <summary>
		/// 评价星星4
		/// </summary>
		public int Star4 { get; set; }

		/// <summary>
		/// 评价星星5
		/// </summary>
		public int Star5 { get; set; }

		/// <summary>
		/// 商品添加时间
		/// </summary>
		public DateTime AddTime { get; set; }

		/// <summary>
		/// 商品描述
		/// </summary>
		public string Description { get; set; }

		public int GetStarLevel()
		{
			int goodStars = Star1 + Star2 + Star3;
			int allStars = goodStars + Star4 + Star5;

			if (allStars == 0)
				return 100;
			return goodStars * 100 / allStars;
		}
	}
}
