﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/busifavor/users/{openid}/coupons/{coupon_code}/appids/{appid} 接口的响应。</para>
    /// </summary>
    public class GetMarketingBusifavorUserCouponByCouponCodeResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class CouponUseRule : GetMarketingBusifavorStockByStockIdResponse.Types.CouponUseRule
            {
            }

            public class Entrance : GetMarketingBusifavorStockByStockIdResponse.Types.Entrance
            {
            }

            public class Pattern : GetMarketingBusifavorStockByStockIdResponse.Types.Pattern
            {
            }
        }

        /// <summary>
        /// 获取或设置商家券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string CouponCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_name")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_name")]
        public string StockName { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_type")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
        public string StockType { get; set; } = default!;

        /// <summary>
        /// 获取或设置券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_state")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_state")]
        public string CouponState { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次归属商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("belong_merchant")]
        [System.Text.Json.Serialization.JsonPropertyName("belong_merchant")]
        public string BelongMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否允许转赠。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transferable")]
        [System.Text.Json.Serialization.JsonPropertyName("transferable")]
        public bool? IsTransferable { get; set; }

        /// <summary>
        /// 获取或设置是否允许分享链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shareable")]
        [System.Text.Json.Serialization.JsonPropertyName("shareable")]
        public bool? IsShareable { get; set; }

        /// <summary>
        /// 获取或设置券核销规则信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_use_rule")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_use_rule")]
        public Types.CouponUseRule CouponUseRule { get; set; } = default!;

        /// <summary>
        /// 获取或设置自定义入口信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_entrance")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_entrance")]
        public Types.Entrance? CustomEntrance { get; set; }

        /// <summary>
        /// 获取或设置样式设置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("display_pattern_info")]
        [System.Text.Json.Serialization.JsonPropertyName("display_pattern_info")]
        public Types.Pattern DisplayPattern { get; set; } = default!;

        /// <summary>
        /// 获取或设置适用商品范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_name")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
        public string GoodsName { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment")]
        [System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 获取或设置券可使用开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("available_start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset AvailableStartTime { get; set; }

        /// <summary>
        /// 获取或设置券过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置领券时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receive_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ReceiveTime { get; set; }

        /// <summary>
        /// 获取或设置发券时商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("send_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("send_request_no")]
        public string SendOutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置核销时商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("use_request_no")]
        public string? UseOutRequestNumber { get; set; }

        /// <summary>
        /// 获取或设置核销请求时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("use_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("use_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
        public DateTimeOffset? UseTime { get; set; }
    }
}
