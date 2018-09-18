using System;
using System.Collections.Generic;
using Abp.Dependency;
using BriefShop.Config;
using BriefShop.Core;

namespace BriefShop.Web.Framework
{
    /// <summary>
    /// PC前台工作上下文类
    /// </summary>
    public class WebWorkContext : ISingletonDependency
	{
		public ShopConfig ShopConfig = BSPConfig.ShopConfig;//商城配置信息

        public bool IsHttpAjax;//当前请求是否为ajax请求

        public string IP;//用户ip

        public Region Region;//区域信息

        public int RegionId;//区域id

        public string Url;//当前url

        public string UrlReferrer;//上一次访问的url

        public string SessionId;//用户SessionId

        public int UserId = -1;//用户id

        public string UserName;//用户名

        public string UserEmail;//用户邮箱

        public string UserMobile;//用户手机号

        public string NickName;//用户昵称

        public string Avatar;//用户头像

        public string Password;//用户密码

        public string EncryptPwd;//加密密码

        public string PayCreditName;//支付积分名称

        public int PayCreditCount = 0;//支付积分数量

        public string RankCreditName;//等级积分名称

        public int RankCreditCount = 0;//等级积分数量

        public User User;//用户信息

        public int UserRid = -1;//用户等级id

        public UserRank UserRank;//用户等级信息

        public string UserRTitle;//用户等级标题

        public int AdminGid = -1;//用户管理员组id

        public AdminGroup AdminGroup;//用户管理员组信息

        public string AdminGTitle;//管理员组标题

        public string Controller;//控制器

        public string Action;//动作方法

        public string PageKey;//页面标示符

        public string Theme;//当前主题

        public string ImageCDN;//图片cdn

        public string CSSCDN;//csscdn

        public string ScriptCDN;//脚本cdn

        public int OnlineUserCount = 0;//在线总人数

        public int OnlineMemberCount = 0;//在线会员数

        public int OnlineGuestCount = 0;//在线游客数

        public string SearchWord;//搜索词

        public int CartProductCount = 0;//购物车中商品数量

        public List<Nav> NavList;//导航列表

        public FriendLink[] FriendLinkList;//友情链接列表

        public List<Help> HelpList;//帮助列表

        public DateTime StartExecuteTime;//页面开始执行时间

        public double ExecuteTime;//页面执行时间

        public int ExecuteCount = 0;//执行的sql语句数目

        public string ExecuteDetail;//执行的sql语句细节

        public string ShopVersion = BSPVersion.SHOP_VERSION;//商城版本

        public string ShopCopyright = BSPVersion.SHOP_COPYRIGHT;//商城版权

    }
}