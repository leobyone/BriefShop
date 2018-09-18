using BriefShop.Config;
using System;
using System.IO;

namespace BriefShop.Core
{
	/// <summary>
	/// BriefShop配置管理类
	/// </summary>
	public partial class BSPConfig
	{
		private static object _locker = new object();//锁对象

		private static IConfigManage _iconfigmanage = null;//配置管理
		private static ShopConfig _ShopConfig = null;//商城基本配置信息
		private static EmailConfig _EmailConfig = null;//邮件配置信息
		private static SMSConfig _SMSConfig = null;//短信配置信息
		private static CreditConfig _CreditConfig = null;//积分配置信息
		private static UploadConfig _UploadConfig = null;//上传配置信息
		private static EventConfig _EventConfig = null;//事件配置信息
		private static MemcachedCacheConfig _MemcachedCacheConfig = null;//Memcached缓存配置信息
		private static MemcachedSessionConfig _MemcachedSessionConfig = null;//Memcached会话状态配置信息
		private static MemcachedCartConfig _MemcachedCartConfig = null;//Memcached购物车配置信息
		private static RabbitMQOrderConfig _RabbitMQOrderConfig = null;//RabbitMQ订单配置信息

		static BSPConfig()
		{
			_iconfigmanage = new ConfigManage();
			_ShopConfig = _iconfigmanage.GetShopConfig();
		}

		/// <summary>
		/// 商城基本配置信息
		/// </summary>
		public static ShopConfig ShopConfig
		{
			get { return _ShopConfig; }
		}

		/// <summary>
		/// 邮件配置信息
		/// </summary>
		public static EmailConfig EmailConfig
		{
			get
			{
				if (_EmailConfig == null)
				{
					lock (_locker)
					{
						if (_EmailConfig == null)
						{
							_EmailConfig = _iconfigmanage.GetEmailConfig();
						}
					}
				}

				return _EmailConfig;
			}
		}

		/// <summary>
		/// 短息配置信息
		/// </summary>
		public static SMSConfig SMSConfig
		{
			get
			{
				if (_SMSConfig == null)
				{
					lock (_locker)
					{
						if (_SMSConfig == null)
						{
							_SMSConfig = _iconfigmanage.GetSMSConfig();
						}
					}
				}
				return _SMSConfig;
			}
		}

		/// <summary>
		/// 积分配置信息
		/// </summary>
		public static CreditConfig CreditConfig
		{
			get
			{
				if (_CreditConfig == null)
				{
					lock (_locker)
					{
						if (_CreditConfig == null)
						{
							_CreditConfig = _iconfigmanage.GetCreditConfig();
						}
					}
				}
				return _CreditConfig;
			}
		}

		/// <summary>
		/// 上传配置信息
		/// </summary>
		public static UploadConfig UploadConfig
		{
			get
			{
				if (_UploadConfig == null)
				{
					lock (_locker)
					{
						if (_UploadConfig == null)
						{
							_UploadConfig = _iconfigmanage.GetUploadConfig();
						}
					}
				}
				return _UploadConfig;
			}
		}

		/// <summary>
		/// 事件配置信息
		/// </summary>
		public static EventConfig EventConfig
		{
			get
			{
				if (_EventConfig == null)
				{
					lock (_locker)
					{
						if (_EventConfig == null)
						{
							_EventConfig = _iconfigmanage.GetEventConfig();
						}
					}
				}
				return _EventConfig;
			}
		}

		/// <summary>
		/// Memcached缓存配置信息
		/// </summary>
		public static MemcachedCacheConfig MemcachedCacheConfig
		{
			get
			{
				if (_MemcachedCacheConfig == null)
				{
					lock (_locker)
					{
						if (_MemcachedCacheConfig == null)
						{
							_MemcachedCacheConfig = _iconfigmanage.GetMemcachedCacheConfig();
						}
					}
				}
				return _MemcachedCacheConfig;
			}
		}

		/// <summary>
		/// Memcached会话状态配置信息
		/// </summary>
		public static MemcachedSessionConfig MemcachedSessionConfig
		{
			get
			{
				if (_MemcachedSessionConfig == null)
				{
					lock (_locker)
					{
						if (_MemcachedSessionConfig == null)
						{
							_MemcachedSessionConfig = _iconfigmanage.GetMemcachedSessionConfig();
						}
					}
				}
				return _MemcachedSessionConfig;
			}
		}

		/// <summary>
		/// Memcached购物车配置信息
		/// </summary>
		public static MemcachedCartConfig MemcachedCartConfig
		{
			get
			{
				if (_MemcachedCartConfig == null)
				{
					lock (_locker)
					{
						if (_MemcachedCartConfig == null)
						{
							_MemcachedCartConfig = _iconfigmanage.GetMemcachedCartConfig();
						}
					}
				}
				return _MemcachedCartConfig;
			}
		}

		/// <summary>
		/// RabbitMQ订单配置信息
		/// </summary>
		public static RabbitMQOrderConfig RabbitMQOrderConfig
		{
			get
			{
				if (_RabbitMQOrderConfig == null)
				{
					lock (_locker)
					{
						if (_RabbitMQOrderConfig == null)
						{
							_RabbitMQOrderConfig = _iconfigmanage.GetRabbitMQOrderConfig();
						}
					}
				}
				return _RabbitMQOrderConfig;
			}
		}



		/// <summary>
		/// 保存商城配置信息
		/// </summary>
		public static void SaveShopConfig(ShopConfig ShopConfig)
		{
			lock (_locker)
			{
				if (_iconfigmanage.SaveShopConfig(ShopConfig))
					_ShopConfig = ShopConfig;
			}
		}

		/// <summary>
		/// 保存邮件配置信息
		/// </summary>
		public static void SaveEmailConfig(EmailConfig EmailConfig)
		{
			lock (_locker)
			{
				if (_iconfigmanage.SaveEmailConfig(EmailConfig))
					_EmailConfig = null;
			}
		}

		/// <summary>
		/// 保存短信配置信息
		/// </summary>
		public static void SaveSMSConfig(SMSConfig SMSConfig)
		{
			lock (_locker)
			{
				if (_iconfigmanage.SaveSMSConfig(SMSConfig))
					_SMSConfig = null;
			}
		}

		/// <summary>
		/// 保存积分配置信息
		/// </summary>
		public static void SaveCreditConfig(CreditConfig CreditConfig)
		{
			lock (_locker)
			{
				if (_iconfigmanage.SaveCreditConfig(CreditConfig))
					_CreditConfig = null;
			}
		}

		/// <summary>
		/// 保存上传配置信息
		/// </summary>
		public static void SaveUploadConfig(UploadConfig UploadConfig)
		{
			lock (_locker)
			{
				if (_iconfigmanage.SaveUploadConfig(UploadConfig))
					_CreditConfig = null;
			}
		}

		/// <summary>
		/// 保存事件配置信息
		/// </summary>
		public static void SaveEventConfig(EventConfig EventConfig)
		{
			lock (_locker)
			{
				if (_iconfigmanage.SaveEventConfig(EventConfig))
					_EventConfig = null;
			}
		}
	}
}
