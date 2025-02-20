﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/limiteddiscount/add 接口的请求。</para>
    /// </summary>
    public class ProductLimitedDiscountAddRequest : WechatApiRequest
    {
        public static class Types
        {
            public class SKU
            {
                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置抢购价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_price")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                public int SalePrice { get; set; }

                /// <summary>
                /// 获取或设置抢购库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_stock")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_stock")]
                public int SaleStock { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置抢购任务开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置抢购任务开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limited_discount_sku_list")]
        [System.Text.Json.Serialization.JsonPropertyName("limited_discount_sku_list")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
    }
}
