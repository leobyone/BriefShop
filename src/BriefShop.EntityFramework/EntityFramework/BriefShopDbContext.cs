using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using BriefShop.Core;

namespace BriefShop.EntityFramework
{
    public class BriefShopDbContext : AbpDbContext
    {
		//TODO: Define an IDbSet for each Entity...
		public virtual IDbSet<AdminAction> AdminActions { get; set; }
		public virtual IDbSet<AdminGroup> AdminGroups { get; set; }
		public virtual IDbSet<AdminOperateLog> AdminOperateLogs { get; set; }
		public virtual IDbSet<AdvertPosition> AdvertPositions { get; set; }
		public virtual IDbSet<Advert> Adverts { get; set; }
		public virtual IDbSet<AttributeGroup> AttributeGroups { get; set; }
		public virtual IDbSet<Attribute> Attributes { get; set; }
		public virtual IDbSet<AttributeValue> AttributeValues { get; set; }
		public virtual IDbSet<BannedIP> BannedIPs { get; set; }
		public virtual IDbSet<Brand> Brands { get; set; }
		public virtual IDbSet<BrowseHistory> BrowseHistories { get; set; }
		public virtual IDbSet<BuySendProduct> BuySendProducts { get; set; }
		public virtual IDbSet<BuySendPromotion> BuySendPromotions { get; set; }
		public virtual IDbSet<Category> Categories { get; set; }
		public virtual IDbSet<CouponProduct> CouponProducts { get; set; }
		public virtual IDbSet<Coupon> Coupons { get; set; }
		public virtual IDbSet<CouponType> CouponTypes { get; set; }
		public virtual IDbSet<CreditLog> CreditLogs { get; set; }
		public virtual IDbSet<EventLog> EventLogs { get; set; }
		public virtual IDbSet<Favorite> Favorites { get; set; }
		public virtual IDbSet<FilterWord> FilterWords { get; set; }
		public virtual IDbSet<FriendLink> FriendLinks { get; set; }
		public virtual IDbSet<FullCutProduct> FullCutProducts { get; set; }
		public virtual IDbSet<FullCutPromotion> FullCutPromotions { get; set; }
		public virtual IDbSet<FullSendProduct> FullSendProducts { get; set; }
		public virtual IDbSet<FullSendPromotion> FullSendPromotions { get; set; }
		public virtual IDbSet<GiftPromotion> GiftPromotions { get; set; }
		public virtual IDbSet<Gift> Gifts { get; set; }
		public virtual IDbSet<Help> Helps { get; set; }
		public virtual IDbSet<LoginFailLog> LoginFailLogs { get; set; }
		public virtual IDbSet<Nav> Navs { get; set; }
		public virtual IDbSet<News> News { get; set; }
		public virtual IDbSet<NewsType> NewsTypes { get; set; }
		public virtual IDbSet<OAuth> OAuth { get; set; }
		public virtual IDbSet<OnlineTime> OnlineTimes { get; set; }
		public virtual IDbSet<OnlineUser> OnlineUsers { get; set; }
		public virtual IDbSet<OrderAction> OrderActions { get; set; }
		public virtual IDbSet<OrderAfterService> OrderAfterServices { get; set; }
		public virtual IDbSet<OrderProduct> OrderProducts { get; set; }
		public virtual IDbSet<OrderRefund> OrderRefunds { get; set; }
		public virtual IDbSet<Order> Orders { get; set; }
		public virtual IDbSet<ProductAttribute> ProductAttributes { get; set; }
		public virtual IDbSet<ProductConsult> ProductConsults { get; set; }
		public virtual IDbSet<ProductConsultType> ProductConsultTypes { get; set; }
		public virtual IDbSet<ProductImage> ProductImages { get; set; }
		public virtual IDbSet<ProductKeyword> ProductKeywords { get; set; }
		public virtual IDbSet<ProductReviewQuality> ProductReviewQuality { get; set; }
		public virtual IDbSet<ProductReview> ProductReviews { get; set; }
		public virtual IDbSet<Product> Products { get; set; }
		public virtual IDbSet<ProductSKU> ProductSKUs { get; set; }
		public virtual IDbSet<ProductStat> ProductStats { get; set; }
		public virtual IDbSet<ProductStock> ProductStocks { get; set; }
		public virtual IDbSet<PVStat> PVStats { get; set; }
		public virtual IDbSet<Region> Regions { get; set; }
		public virtual IDbSet<RelateProduct> RelateProducts { get; set; }
		public virtual IDbSet<SearchHistory> SearchHistories { get; set; }
		public virtual IDbSet<ShipAddress> ShipAddresses { get; set; }
		public virtual IDbSet<ShipCompany> ShipCompanies { get; set; }
		public virtual IDbSet<SignProduct> SignProducts { get; set; }
		public virtual IDbSet<SinglePromotion> SinglePromotions { get; set; }
		public virtual IDbSet<SuitProduct> SuitProducts { get; set; }
		public virtual IDbSet<SuitPromotion> SuitPromotions { get; set; }
		public virtual IDbSet<TimeProduct> TimeProducts { get; set; }
		public virtual IDbSet<Topic> Topics { get; set; }
		public virtual IDbSet<UserDetail> UserDetails { get; set; }
		public virtual IDbSet<UserRank> UserRanks { get; set; }
		public virtual IDbSet<User> Users { get; set; }
		
		/* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
		public BriefShopDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BriefShopDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BriefShopDbContext since ABP automatically handles it.
         */
        public BriefShopDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public BriefShopDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public BriefShopDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
