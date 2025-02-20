﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/checkencryptedmsg 接口的请求。</para>
    /// </summary>
    public class WxaBusinessCheckEncryptedMessageRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置加密数据哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encrypted_msg_hash")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypted_msg_hash")]
        public string EncryptedMessageHash { get; set; } = string.Empty;
    }
}
