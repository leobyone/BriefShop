using System;
using System.Collections.Generic;

namespace BriefShop.Core
{
    /// <summary>
    /// 事件配置信息类
    /// </summary>
    [Serializable]
    public class EventConfig : IConfig
    {
        private int _bspeventstate;//BriefShop事件状态
        private int _bspeventperiod;//BriefShop事件执行间隔(单位为分钟)

        /// <summary>
        /// BriefShop事件状态
        /// </summary>
        public int BSPEventState
        {
            get { return _bspeventstate; }
            set { _bspeventstate = value; }
        }
        /// <summary>
        /// BriefShop事件执行间隔(单位为分钟)
        /// </summary>
        public int BSPEventPeriod
        {
            get { return _bspeventperiod; }
            set { _bspeventperiod = value; }
        }
    }
}
