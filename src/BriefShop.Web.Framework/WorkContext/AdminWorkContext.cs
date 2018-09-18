using System;

using BriefShop.Core;

namespace BriefShop.Web.Framework
{
    /// <summary>
    /// PC后台工作上下文类
    /// </summary>
    public class AdminWorkContext
    {
        public ShopConfig ShopConfig = BSPConfig.ShopConfig;//商城配置信息

        public bool IsHttpAjax;//当前请求是否为ajax请求

        public string IP;//用户ip

        public Region Region;//区域信息

        public int RegionId;//区域id

        public string Url;//当前url

        public string UrlReferrer;//上一次访问的url

        public string Sid;//用户sid

        public int Uid = -1;//用户id

        public string UserName;//用户名

        public string UserEmail;//用户邮箱

        public string UserMobile;//用户手机号

        public string NickName;//用户昵称

        public string Avatar;//用户头像

        public string Password;//用户密码

        public string EncryptPwd;//加密密码

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

        public string ImageCDN;//图片cdn

        public string CSSCDN;//csscdn

        public string ScriptCDN;//脚本cdn
    }
}
