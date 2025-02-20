﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/get 接口的请求。</para>
    /// </summary>
    public class CgibinUserGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置第一个拉取的 OpenId。不填默认从头开始拉取。
        /// </summary>
        public string? NextOpenId { get; set; }
    }
}
