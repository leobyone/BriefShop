namespace BriefShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 256),
                        Action = c.String(),
                        ParentId = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdminGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        ActionList = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdminOperateLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        NickName = c.String(),
                        AdminGroupId = c.Int(nullable: false),
                        AdminGroupTitle = c.String(),
                        Operation = c.String(),
                        Description = c.String(maxLength: 200),
                        IP = c.String(),
                        OperateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdvertPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisplayOrder = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Adverts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClickCount = c.Int(nullable: false),
                        AdvertPositionId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Image = c.String(),
                        Url = c.String(),
                        ExtField1 = c.String(),
                        ExtField2 = c.String(),
                        ExtField3 = c.String(),
                        ExtField4 = c.String(),
                        ExtField5 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AttributeGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Attributes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        CategoryId = c.Int(nullable: false),
                        AttributeGroupId = c.Int(nullable: false),
                        ShowType = c.Int(nullable: false),
                        IsFilter = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AttributeValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsInput = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        AttrId = c.Int(nullable: false),
                        AttrValue = c.String(nullable: false),
                        AttrName = c.String(nullable: false),
                        AttrDisplayOrder = c.String(nullable: false),
                        AttrShowType = c.String(nullable: false),
                        AttrGroupId = c.Int(nullable: false),
                        AttrGroupName = c.Int(nullable: false),
                        AttrGroupDisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BannedIPs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IP = c.String(nullable: false),
                        LiftBanTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisplayOrder = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BrowseHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Times = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BuySendProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        PmId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BuySendPromotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        UserRankLower = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        BuyCount = c.Int(nullable: false),
                        SendCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DisplayOrder = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 60),
                        PriceRange = c.String(),
                        ParentId = c.Int(nullable: false),
                        Layer = c.Int(nullable: false),
                        HasChild = c.Int(nullable: false),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CouponProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CouponTypeId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CouponSN = c.String(),
                        UserId = c.Int(nullable: false),
                        CouponTypeId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        UseTime = c.DateTime(nullable: false),
                        UseIP = c.String(),
                        Money = c.Int(nullable: false),
                        ActivateTime = c.DateTime(nullable: false),
                        ActivateIP = c.String(),
                        CreateUserId = c.Int(nullable: false),
                        CreateOrderId = c.Int(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        CreateIP = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CouponTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Money = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        SendMode = c.Int(nullable: false),
                        GetMode = c.Int(nullable: false),
                        UseMode = c.Int(nullable: false),
                        UserRankLower = c.Int(nullable: false),
                        OrderAmountLower = c.Int(nullable: false),
                        LimitCategoryId = c.Int(nullable: false),
                        LimitBrandId = c.Int(nullable: false),
                        LimitProductId = c.Int(nullable: false),
                        SendStartTime = c.DateTime(nullable: false),
                        SendEndTime = c.DateTime(nullable: false),
                        UseExpireTime = c.Int(nullable: false),
                        UseStartTime = c.DateTime(nullable: false),
                        UseEndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CreditLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PayCredits = c.Int(nullable: false),
                        RankCredits = c.Int(nullable: false),
                        Action = c.Int(nullable: false),
                        ActionCode = c.Int(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                        ActionDes = c.String(),
                        Operator = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EventLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(),
                        Title = c.String(nullable: false, maxLength: 200),
                        Server = c.String(),
                        ExecuteTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FilterWords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Match = c.String(maxLength: 250),
                        Replace = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FriendLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Title = c.String(maxLength: 100),
                        Logo = c.String(),
                        Url = c.String(),
                        Target = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FullCutProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PmId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FullCutPromotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        UserRankLower = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        LimitMoney1 = c.Int(nullable: false),
                        CutMoney1 = c.Int(nullable: false),
                        LimitMoney2 = c.Int(nullable: false),
                        CutMoney2 = c.Int(nullable: false),
                        LimitMoney3 = c.Int(nullable: false),
                        CutMoney3 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FullSendProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PmId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FullSendPromotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        UserRankLower = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        LimitMoney = c.Int(nullable: false),
                        AddMoney = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GiftPromotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        StartTime1 = c.DateTime(nullable: false),
                        EndTime1 = c.DateTime(nullable: false),
                        StartTime2 = c.DateTime(nullable: false),
                        EndTime2 = c.DateTime(nullable: false),
                        StartTime3 = c.DateTime(nullable: false),
                        EndTime3 = c.DateTime(nullable: false),
                        UserRankLower = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        QuotaUpper = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Gifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PmId = c.Int(nullable: false),
                        GiftId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Helps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 60),
                        Url = c.String(),
                        Description = c.String(),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LoginFailLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginIP = c.Long(nullable: false),
                        FailTimes = c.Int(nullable: false),
                        LastLoginTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Navs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Layer = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Title = c.String(maxLength: 50),
                        Url = c.String(),
                        Target = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NewsTypeId = c.Int(nullable: false),
                        IsShow = c.Int(nullable: false),
                        IsTop = c.Int(nullable: false),
                        IsHome = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        Title = c.String(nullable: false, maxLength: 100),
                        Url = c.String(),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NewsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 60),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OAuths",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        OpenId = c.String(),
                        Server = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OnlineTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Week = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OnlineUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SessionId = c.String(),
                        IP = c.String(),
                        RegionId = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderActions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        RealName = c.String(),
                        AdminGroupId = c.Int(nullable: false),
                        AdminGroupTitle = c.String(),
                        ActionType = c.Int(nullable: false),
                        ActionTime = c.DateTime(nullable: false),
                        ActionDescription = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderAfterServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        OrderProductId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Money = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.Int(nullable: false),
                        ApplyReason = c.String(),
                        ApplyTime = c.DateTime(nullable: false),
                        CheckResult = c.String(),
                        CheckTime = c.DateTime(nullable: false),
                        ShipCoId1 = c.Int(nullable: false),
                        ShipCoName1 = c.String(),
                        ShipSN1 = c.String(),
                        SendTime = c.DateTime(nullable: false),
                        ReceiveTime = c.DateTime(nullable: false),
                        ShipCoId2 = c.Int(nullable: false),
                        ShipCoName2 = c.String(),
                        ShipSN2 = c.String(),
                        BackTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        SessionId = c.String(),
                        ProductId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        DiscountPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsReview = c.Int(nullable: false),
                        RealCount = c.Int(nullable: false),
                        BuyCount = c.Int(nullable: false),
                        SendCount = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        PayCredits = c.Int(nullable: false),
                        CouponTypeId = c.Int(nullable: false),
                        ExtCode1 = c.Int(nullable: false),
                        ExtCode2 = c.Int(nullable: false),
                        ExtCode3 = c.Int(nullable: false),
                        ExtCode4 = c.Int(nullable: false),
                        ExtCode5 = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderRefunds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        State = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ASId = c.Int(nullable: false),
                        RefundMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApplyTime = c.DateTime(nullable: false),
                        RefundSN = c.String(),
                        RefundTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OSN = c.String(),
                        UserId = c.Int(nullable: false),
                        OrderState = c.Int(nullable: false),
                        ProductAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SurplusMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsReview = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        ShipSN = c.String(),
                        ShipSystemName = c.String(),
                        ShipFriendName = c.String(),
                        ShipTime = c.DateTime(nullable: false),
                        PayMode = c.Int(nullable: false),
                        PaySN = c.String(),
                        PaySystemName = c.String(),
                        PayFriendName = c.String(),
                        PayTime = c.DateTime(nullable: false),
                        RegionId = c.Int(nullable: false),
                        Consignee = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        ZipCode = c.String(),
                        Address = c.String(),
                        BestTime = c.DateTime(nullable: false),
                        ShipFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FullCut = c.Int(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PayCreditCount = c.Int(nullable: false),
                        PayCreditMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CouponMoney = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        BuyerRemark = c.String(),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductAttributes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        AttributeId = c.Int(nullable: false),
                        AttributeValueId = c.Int(nullable: false),
                        InputValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductConsults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ConsultTypeId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        ConsultUserId = c.Int(nullable: false),
                        ReplyUserId = c.Int(nullable: false),
                        ConsultTime = c.DateTime(nullable: false),
                        ReplyTime = c.DateTime(nullable: false),
                        ConsultMessage = c.String(),
                        ReplyMessage = c.String(),
                        ConsultNickName = c.String(),
                        ReplyNickName = c.String(),
                        ConsultIP = c.String(),
                        ReplyIP = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductConsultTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 30),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ShowImg = c.String(),
                        IsMain = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductKeywords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Keyword = c.String(maxLength: 40),
                        ProductId = c.Int(nullable: false),
                        Relevancy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductReviewQualities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReviewId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        VoteTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductReviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        OPRId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Star = c.Int(nullable: false),
                        Quality = c.Int(nullable: false),
                        Message = c.String(),
                        ReviewTime = c.DateTime(nullable: false),
                        PayCredits = c.Int(nullable: false),
                        BuyTime = c.DateTime(nullable: false),
                        IP = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PSN = c.String(),
                        CategoryId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        SKUGid = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 200),
                        ShopPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MarketPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        State = c.Int(nullable: false),
                        IsBest = c.Int(nullable: false),
                        IsHot = c.Int(nullable: false),
                        IsNew = c.Int(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        ShowImg = c.String(),
                        SaleCount = c.Int(nullable: false),
                        VisitCount = c.Int(nullable: false),
                        ReviewCount = c.Int(nullable: false),
                        Star1 = c.Int(nullable: false),
                        Star2 = c.Int(nullable: false),
                        Star3 = c.Int(nullable: false),
                        Star4 = c.Int(nullable: false),
                        Star5 = c.Int(nullable: false),
                        AddTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductSKUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SKUGid = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        AttributeId = c.Int(nullable: false),
                        AttributeValueId = c.Int(nullable: false),
                        InputValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductStats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Category = c.String(),
                        Value = c.String(),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductStocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Limit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PVStats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Value = c.String(),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Spell = c.String(),
                        ShortSpell = c.String(),
                        DisplayOrder = c.Int(nullable: false),
                        ParentId = c.Int(nullable: false),
                        Layer = c.Int(nullable: false),
                        ProvinceId = c.Int(nullable: false),
                        ProvinceName = c.String(),
                        CityId = c.Int(nullable: false),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RelateProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        RelateProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SearchHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Word = c.String(),
                        Times = c.Int(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShipAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RegionId = c.Int(nullable: false),
                        IsDefault = c.Int(nullable: false),
                        Alias = c.String(),
                        Consignee = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        ZipCode = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShipCompanies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        DisplayOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SignProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sign = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.SinglePromotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        StartTime1 = c.DateTime(nullable: false),
                        EndTime1 = c.DateTime(nullable: false),
                        StartTime2 = c.DateTime(nullable: false),
                        EndTime2 = c.DateTime(nullable: false),
                        StartTime3 = c.DateTime(nullable: false),
                        EndTime3 = c.DateTime(nullable: false),
                        UserRankLower = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Slogan = c.String(),
                        DiscountType = c.Int(nullable: false),
                        DiscountValue = c.Int(nullable: false),
                        CouponTypeId = c.Int(nullable: false),
                        PayCredits = c.Int(nullable: false),
                        IsStock = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        QuotaLower = c.Int(nullable: false),
                        QuotaUpper = c.Int(nullable: false),
                        AllowBuyCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SuitProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PmId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SuitPromotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime1 = c.DateTime(nullable: false),
                        EndTime1 = c.DateTime(nullable: false),
                        StartTime2 = c.DateTime(nullable: false),
                        EndTime2 = c.DateTime(nullable: false),
                        StartTime3 = c.DateTime(nullable: false),
                        EndTime3 = c.DateTime(nullable: false),
                        UserRankLower = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        QuotaUpper = c.Int(nullable: false),
                        OnlyOnce = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TimeProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        OnSaleState = c.Int(nullable: false),
                        OutSaleState = c.Int(nullable: false),
                        OnSaleTime = c.DateTime(nullable: false),
                        OutSaleTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        IsShow = c.Int(nullable: false),
                        SN = c.String(),
                        Title = c.String(nullable: false, maxLength: 100),
                        HeadHtml = c.String(),
                        BodyHtml = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        LastVisitTime = c.DateTime(nullable: false),
                        LastVisitIP = c.String(),
                        LastVisitRgId = c.Int(nullable: false),
                        RegisterTime = c.DateTime(nullable: false),
                        RegisterIP = c.String(),
                        RegisterRegionId = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        RealName = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        IdCard = c.String(),
                        RegionId = c.Int(nullable: false),
                        Address = c.String(),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserRanks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        System = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Avatar = c.String(),
                        CreditsUpper = c.Int(nullable: false),
                        CreditsLower = c.Int(nullable: false),
                        LimitDays = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Mobile = c.String(),
                        Password = c.String(nullable: false),
                        AdminGroupId = c.Int(nullable: false),
                        UserRankId = c.Int(nullable: false),
                        NickName = c.String(),
                        Avatar = c.String(),
                        PayCredits = c.Int(nullable: false),
                        RankCredits = c.Int(nullable: false),
                        VerifyEmail = c.Int(nullable: false),
                        VerifyMobile = c.Int(nullable: false),
                        LiftBanTime = c.DateTime(nullable: false),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SignProducts", "ProductId", "dbo.Products");
            DropIndex("dbo.SignProducts", new[] { "ProductId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRanks");
            DropTable("dbo.UserDetails");
            DropTable("dbo.Topics");
            DropTable("dbo.TimeProducts");
            DropTable("dbo.SuitPromotions");
            DropTable("dbo.SuitProducts");
            DropTable("dbo.SinglePromotions");
            DropTable("dbo.SignProducts");
            DropTable("dbo.ShipCompanies");
            DropTable("dbo.ShipAddresses");
            DropTable("dbo.SearchHistories");
            DropTable("dbo.RelateProducts");
            DropTable("dbo.Regions");
            DropTable("dbo.PVStats");
            DropTable("dbo.ProductStocks");
            DropTable("dbo.ProductStats");
            DropTable("dbo.ProductSKUs");
            DropTable("dbo.Products");
            DropTable("dbo.ProductReviews");
            DropTable("dbo.ProductReviewQualities");
            DropTable("dbo.ProductKeywords");
            DropTable("dbo.ProductImages");
            DropTable("dbo.ProductConsultTypes");
            DropTable("dbo.ProductConsults");
            DropTable("dbo.ProductAttributes");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderRefunds");
            DropTable("dbo.OrderProducts");
            DropTable("dbo.OrderAfterServices");
            DropTable("dbo.OrderActions");
            DropTable("dbo.OnlineUsers");
            DropTable("dbo.OnlineTimes");
            DropTable("dbo.OAuths");
            DropTable("dbo.NewsTypes");
            DropTable("dbo.News");
            DropTable("dbo.Navs");
            DropTable("dbo.LoginFailLogs");
            DropTable("dbo.Helps");
            DropTable("dbo.Gifts");
            DropTable("dbo.GiftPromotions");
            DropTable("dbo.FullSendPromotions");
            DropTable("dbo.FullSendProducts");
            DropTable("dbo.FullCutPromotions");
            DropTable("dbo.FullCutProducts");
            DropTable("dbo.FriendLinks");
            DropTable("dbo.FilterWords");
            DropTable("dbo.Favorites");
            DropTable("dbo.EventLogs");
            DropTable("dbo.CreditLogs");
            DropTable("dbo.CouponTypes");
            DropTable("dbo.Coupons");
            DropTable("dbo.CouponProducts");
            DropTable("dbo.Categories");
            DropTable("dbo.BuySendPromotions");
            DropTable("dbo.BuySendProducts");
            DropTable("dbo.BrowseHistories");
            DropTable("dbo.Brands");
            DropTable("dbo.BannedIPs");
            DropTable("dbo.AttributeValues");
            DropTable("dbo.Attributes");
            DropTable("dbo.AttributeGroups");
            DropTable("dbo.Adverts");
            DropTable("dbo.AdvertPositions");
            DropTable("dbo.AdminOperateLogs");
            DropTable("dbo.AdminGroups");
            DropTable("dbo.AdminActions");
        }
    }
}
