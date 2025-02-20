﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.LOCATION 事件的数据。</para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90000/90135/90240 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90001/90143/90376 </para>
    /// <para>REF: https://open.work.weixin.qq.com/api/doc/90002/90151/90858 </para>
    /// </summary>
    public class LocationPushEvent : WechatWorkEvent, WechatWorkEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置应用类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AppType", IsNullable = true)]
        public string? AppType { get; set; }

        /// <summary>
        /// 获取或设置地理位置纬度。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// 获取或设置地理位置经度。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// 获取或设置地理位置精度。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Precision")]
        public double Precision { get; set; }
    }
}
