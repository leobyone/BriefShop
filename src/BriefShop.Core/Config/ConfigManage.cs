using Abp.Dependency;
using BriefShop.Core;
using System;

namespace BriefShop.Config
{
	/// <summary>
	/// 配置管理类
	/// </summary>
	public partial class ConfigManage : ITransientDependency, IConfigManage
	{
		#region 私有字段

		private readonly string _shopconfigfilepath = "/App_Data/shop.config";//商城基本配置信息文件路径
		private readonly string _emailconfigfilepath = "/App_Data/email.config";//邮件配置信息文件路径
		private readonly string _smsconfigfilepath = "/App_Data/sms.config";//短信配置信息文件路径
		private readonly string _creditconfigfilepath = "/App_Data/credit.config";//积分配置信息文件路径
		private readonly string _uploadconfigfilepath = "/App_Data/upload.config";//上传配置信息文件路径
		private readonly string _eventconfigfilepath = "/App_Data/event.config";//事件配置信息文件路径
		private readonly string _memcachedcacheconfigfilepath = "/App_Data/memcachedcache.config";//Memcached缓存配置信息文件路径
		private readonly string _memcachedsessionconfigfilepath = "/App_Data/memcachedsession.config";//Memcached会话状态配置信息文件路径
		private readonly string _memcachedcartconfigfilepath = "/App_Data/memcachedcart.config";//Memcached购物车配置信息文件路径
		private readonly string _rabbitmqorderconfigfilepath = "/App_Data/rabbitmqorder.config";//RabbitMQ订单配置信息文件路径

		#endregion

		#region 帮助方法

		/// <summary>
		/// 从文件中加载配置信息
		/// </summary>
		/// <param name="configType">配置信息类型</param>
		/// <param name="configFile">配置信息文件路径</param>
		/// <returns>配置信息</returns>
		private IConfig LoadConfig(Type configType, string configFile)
		{
			return (IConfig)IOHelper.DeserializeFromXML(configType, configFile);
		}

		/// <summary>
		/// 将配置信息保存到文件中
		/// </summary>
		/// <param name="config">配置信息</param>
		/// <param name="configFile">保存路径</param>
		/// <returns>是否保存成功</returns>
		private bool SaveConfig(IConfig config, string configFile)
		{
			return IOHelper.SerializeToXml(config, configFile);
		}

		#endregion

		/// <summary>
		/// 保存商城基本配置
		/// </summary>
		/// <param name="configInfo">商城基本配置信息</param>
		/// <returns>是否保存结果</returns>
		public bool SaveShopConfig(ShopConfig config)
		{
			return SaveConfig(config, IOHelper.GetMapPath(_shopconfigfilepath));
		}

		/// <summary>
		/// 获得商城基本配置
		/// </summary>
		public ShopConfig GetShopConfig()
		{
			return (ShopConfig)LoadConfig(typeof(ShopConfig), IOHelper.GetMapPath(_shopconfigfilepath));
		}

		/// <summary>
		/// 保存邮件配置
		/// </summary>
		/// <param name="configInfo">邮件配置信息</param>
		/// <returns>是否保存结果</returns>
		public bool SaveEmailConfig(EmailConfig config)
		{
			return SaveConfig(config, IOHelper.GetMapPath(_emailconfigfilepath));
		}

		/// <summary>
		/// 获得邮件配置
		/// </summary>
		public EmailConfig GetEmailConfig()
		{
			return (EmailConfig)LoadConfig(typeof(EmailConfig), IOHelper.GetMapPath(_emailconfigfilepath));
		}

		/// <summary>
		/// 保存短信配置
		/// </summary>
		/// <param name="config">短信配置信息</param>
		/// <returns>是否保存结果</returns>
		public bool SaveSMSConfig(SMSConfig config)
		{
			return SaveConfig(config, IOHelper.GetMapPath(_smsconfigfilepath));
		}

		/// <summary>
		/// 获得短信配置
		/// </summary>
		public SMSConfig GetSMSConfig()
		{
			return (SMSConfig)LoadConfig(typeof(SMSConfig), IOHelper.GetMapPath(_smsconfigfilepath));
		}

		/// <summary>
		/// 保存积分配置
		/// </summary>
		/// <param name="config">积分配置信息</param>
		/// <returns>是否保存结果</returns>
		public bool SaveCreditConfig(CreditConfig config)
		{
			return SaveConfig(config, IOHelper.GetMapPath(_creditconfigfilepath));
		}

		/// <summary>
		/// 获得积分配置
		/// </summary>
		/// <returns></returns>
		public CreditConfig GetCreditConfig()
		{
			return (CreditConfig)LoadConfig(typeof(CreditConfig), IOHelper.GetMapPath(_creditconfigfilepath));
		}

		/// <summary>
		/// 保存上传配置
		/// </summary>
		/// <param name="config">上传配置信息</param>
		/// <returns>是否保存成功</returns>
		public bool SaveUploadConfig(UploadConfig config)
		{
			return SaveConfig(config, IOHelper.GetMapPath(_uploadconfigfilepath));
		}

		/// <summary>
		/// 获得上传配置
		/// </summary>
		public UploadConfig GetUploadConfig()
		{
			return (UploadConfig)LoadConfig(typeof(UploadConfig), IOHelper.GetMapPath(_uploadconfigfilepath));
		}

		/// <summary>
		/// 保存事件配置
		/// </summary>
		/// <param name="config">事件配置信息</param>
		/// <returns>是否保存成功</returns>
		public bool SaveEventConfig(EventConfig config)
		{
			return SaveConfig(config, IOHelper.GetMapPath(_eventconfigfilepath));
		}

		/// <summary>
		/// 获得事件配置
		/// </summary>
		/// <returns></returns>
		public EventConfig GetEventConfig()
		{
			return (EventConfig)LoadConfig(typeof(EventConfig), IOHelper.GetMapPath(_eventconfigfilepath));
		}

		/// <summary>
		/// 获得Memcached缓存配置
		/// </summary>
		public MemcachedCacheConfig GetMemcachedCacheConfig()
		{
			return (MemcachedCacheConfig)LoadConfig(typeof(MemcachedCacheConfig), IOHelper.GetMapPath(_memcachedcacheconfigfilepath));
		}

		/// <summary>
		/// 获得Memcached会话状态配置
		/// </summary>
		public MemcachedSessionConfig GetMemcachedSessionConfig()
		{
			return (MemcachedSessionConfig)LoadConfig(typeof(MemcachedSessionConfig), IOHelper.GetMapPath(_memcachedsessionconfigfilepath));
		}

		/// <summary>
		/// 获得Memcached购物车配置
		/// </summary>
		public MemcachedCartConfig GetMemcachedCartConfig()
		{
			return (MemcachedCartConfig)LoadConfig(typeof(MemcachedCartConfig), IOHelper.GetMapPath(_memcachedcartconfigfilepath));
		}

		/// <summary>
		/// 获得RabbitMQ订单配置
		/// </summary>
		public RabbitMQOrderConfig GetRabbitMQOrderConfig()
		{
			return (RabbitMQOrderConfig)LoadConfig(typeof(RabbitMQOrderConfig), IOHelper.GetMapPath(_rabbitmqorderconfigfilepath));
		}
	}
}
