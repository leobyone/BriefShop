using Abp.Domain.Services;

namespace BriefShop.Core
{
	/// <summary>
	/// BriefShop配置管理接口
	/// </summary>
	public partial interface IConfigManage
    {
        /// <summary>
        /// 保存商城基本配置
        /// </summary>
        /// <param name="configInfo">商城基本配置信息</param>
        /// <returns>是否保存成功</returns>
        bool SaveShopConfig(ShopConfig configInfo);

        /// <summary>
        /// 获得商城基本配置
        /// </summary>
        ShopConfig GetShopConfig();

        /// <summary>
        /// 保存邮件配置
        /// </summary>
        /// <param name="configInfo">邮件配置信息</param>
        /// <returns>是否保存成功</returns>
        bool SaveEmailConfig(EmailConfig configInfo);

        /// <summary>
        /// 获得邮件配置
        /// </summary>
        EmailConfig GetEmailConfig();

        /// <summary>
        /// 保存短信配置
        /// </summary>
        /// <param name="configInfo">短信配置信息</param>
        /// <returns>是否保存成功</returns>
        bool SaveSMSConfig(SMSConfig configInfo);

        /// <summary>
        /// 获得短信配置
        /// </summary>
        SMSConfig GetSMSConfig();

        /// <summary>
        /// 保存积分配置
        /// </summary>
        /// <param name="configInfo">积分配置信息</param>
        /// <returns>是否保存成功</returns>
        bool SaveCreditConfig(CreditConfig configInfo);

        /// <summary>
        /// 获得积分配置
        /// </summary>
        CreditConfig GetCreditConfig();

        /// <summary>
        /// 保存上传配置
        /// </summary>
        /// <param name="configInfo">上传配置信息</param>
        /// <returns>是否保存成功</returns>
        bool SaveUploadConfig(UploadConfig configInfo);

        /// <summary>
        /// 获得上传配置
        /// </summary>
        UploadConfig GetUploadConfig();

        /// <summary>
        /// 保存事件配置
        /// </summary>
        /// <param name="configInfo">事件配置信息</param>
        /// <returns>是否保存成功</returns>
        bool SaveEventConfig(EventConfig configInfo);

        /// <summary>
        /// 获得事件配置
        /// </summary>
        EventConfig GetEventConfig();

        /// <summary>
        /// 获得Memcached缓存配置
        /// </summary>
        MemcachedCacheConfig GetMemcachedCacheConfig();

        /// <summary>
        /// 获得Memcached会话状态配置
        /// </summary>
        MemcachedSessionConfig GetMemcachedSessionConfig();

        /// <summary>
        /// 获得Memcached购物车配置
        /// </summary>
        MemcachedCartConfig GetMemcachedCartConfig();

        /// <summary>
        /// 获得RabbitMQ订单配置
        /// </summary>
        RabbitMQOrderConfig GetRabbitMQOrderConfig();
    }
}
