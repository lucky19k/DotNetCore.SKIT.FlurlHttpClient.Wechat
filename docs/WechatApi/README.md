﻿# SKIT.FlurlHttpClient.Wechat.Api

基于 `Flurl.Http` 的[微信公众平台](<(https://mp.weixin.qq.com/)>) & [微信开放平台](<(https://open.weixin.qq.com/)>) API 客户端。

---

## 功能

-   基于微信公众平台 & 微信开放平台 API 封装。

-   提供了微信公众平台 & 微信开放平台 API 所需的 SHA-1、HMAC-SHA-256、AES 等算法工具类。

-   提供了 JS-SDK 签名、解析回调通知事件等扩展方法。

-   完整微信公众平台 & 微信开放平台 API 一览：

    |     |               微信 API               |           所属平台           |         备注         |
    | :-: | :----------------------------------: | :--------------------------: | :------------------: |
    |  √  |               基础功能               |   公众号 & 小程序 & 小游戏   |                      |
    |  √  |              自定义菜单              |            公众号            |                      |
    |  √  |             基础消息能力             |            公众号            |                      |
    |  √  |               客服消息               |            公众号            |                      |
    |  √  |             微信网页开发             |            公众号            |                      |
    |  √  |               素材管理               |            公众号            |                      |
    |  √  |           图文消息留言管理           |            公众号            |                      |
    |  √  |               用户管理               |            公众号            |                      |
    |  √  |               账号管理               |            公众号            |                      |
    |  √  |               数据统计               |            公众号            |                      |
    |  √  |               微信卡券               |            公众号            |                      |
    |  √  |               微信门店               |            公众号            |                      |
    |  √  |               微信小店               |            公众号            |                      |
    |  √  |               智能接口               |            公众号            |                      |
    |  ×  |       <del>微信设备功能</del>        |      <del>公众号</del>       | 异构协议，需独立模块 |
    |  √  |             微信一物一码             |            公众号            |                      |
    |  √  |               微信发票               |            公众号            |                      |
    |  √  |             微信非税缴费             |            公众号            |                      |
    |  √  |               订阅通知               |   公众号 & 小程序 & 小游戏   |                      |
    |  √  |                 登录                 |       小程序 & 小游戏        |                      |
    |  √  |               用户信息               |       小程序 & 小游戏        |                      |
    |  √  |               数据分析               |       小程序 & 小游戏        |                      |
    |  √  |               动态消息               |       小程序 & 小游戏        |                      |
    |  √  |               客服消息               |   小程序 & 小游戏 & 小商店   |                      |
    |  √  |               插件管理               |            小程序            |                      |
    |  √  |             附近的小程序             |            小程序            |                      |
    |  √  |              URL Scheme              |            小程序            |                      |
    |  √  |               URL Link               |            小程序            |                      |
    |  ×  |           <del>广告</del>            | <del>小程序 & 开放平台</del> | 异构协议，需独立模块 |
    |  √  |               图像处理               |            小程序            |                      |
    |  √  |               即时配送               |            小程序            |                      |
    |  √  |               物流助手               |            小程序            |                      |
    |  √  |                 网络                 |            小程序            |                      |
    |  √  |                 OCR                  |            小程序            |                      |
    |  √  |               运维中心               |            小程序            |                      |
    |  √  |              小程序搜索              |            小程序            |                      |
    |  √  |               服务市场               |            小程序            |                      |
    |  √  |              Short Link              |            小程序            |                      |
    |  √  |               生物认证               |            小程序            |                      |
    |  ×  |     <del>行业能力：乘车码</del>      |      <del>小程序</del>       |       _开发中_       |
    |  √  |               城市服务               |            小程序            |                      |
    |  √  |               虚拟支付               |            小游戏            |                      |
    |  √  |               开放数据               |            小游戏            |                      |
    |  √  |               对局匹配               |            小游戏            |                      |
    |  √  |                帧同步                |            小游戏            |                      |
    |  √  |               小程序码               |       小程序 & 小游戏        |                      |
    |  √  |               内容安全               |       小程序 & 小游戏        |                      |
    |  √  |                云开发                |       小程序 & 小游戏        |                      |
    |  √  |               安全风控               |       小程序 & 小游戏        |                      |
    |  √  |                 直播                 |       小程序 & 小商店        |                      |
    |  √  |                 开店                 |            小商店            |                      |
    |  √  |               服务市场               |            小商店            |                      |
    |  √  |               装修服务               |            小商店            |                      |
    |  √  |               SPU 管理               |            小商店            |                      |
    |  √  |               SKU 管理               |            小商店            |                      |
    |  √  |               订单管理               |            小商店            |                      |
    |  √  |               物流管理               |            小商店            |                      |
    |  √  |             配送方式管理             |            小商店            |                      |
    |  √  |             运费模板管理             |            小商店            |                      |
    |  √  |           线下配送模板管理           |            小商店            |                      |
    |  √  |              优惠券管理              |            小商店            |                      |
    |  √  |               店铺管理               |            小商店            |                      |
    |  √  |             商家地址管理             |            小商店            |                      |
    |  √  |            自定义交易组件            |            小商店            |                      |
    |  √  |              小程序联盟              |            小商店            |                      |
    |  √  |             微信登录功能             |           开放平台           |                      |
    |  √  |            一次性订阅消息            |           开放平台           |                      |
    |  √  |            小程序硬件框架            |           开放平台           |                      |
    |  √  |     第三方平台：代商家注册小程序     |           开放平台           |                      |
    |  √  |        第三方平台：试用小程序        |           开放平台           |                      |
    |  √  |         第三方平台：授权相关         |           开放平台           |                      |
    |  √  |      第三方平台：授权方账号管理      |           开放平台           |                      |
    |  √  |      第三方平台：小程序模板管理      |           开放平台           |                      |
    |  √  |    第三方平台：小程序基础信息管理    |           开放平台           |                      |
    |  √  |      第三方平台：小程序类目管理      |           开放平台           |                      |
    |  √  |      第三方平台：小程序成员管理      |           开放平台           |                      |
    |  √  |      第三方平台：小程序代码管理      |           开放平台           |                      |
    |  √  |      第三方平台：违规和申诉管理      |           开放平台           |                      |
    |  √  |       第三方平台：扫码关注组件       |           开放平台           |                      |
    |  √  | 第三方平台：普通链接二维码与小程序码 |           开放平台           |                      |
    |  √  |      第三方平台：其他小程序业务      |           开放平台           |                      |
    |  √  |        第三方平台：公众号业务        |           开放平台           |                      |
    |  √  |           微信返佣商品推广           |           开放平台           |                      |
    |  √  |                云开发                |           开放平台           |                      |

---

## 基础用法

### 安装：

提示：如果你使用 Visual Studio NuGet 管理器图形化界面，请在搜索结果中勾选“**包括预发行版**”。

```shell
# 通过 NuGet 安装
> Install-Package SKIT.FlurlHttpClient.Wechat.Api

# 通过 dotnet-tools 安装
> dotnet add package SKIT.FlurlHttpClient.Wechat.Api
```

### 初始化：

```csharp
using SKIT.FlurlHttpClient.Wechat;
using SKIT.FlurlHttpClient.Wechat.Api;

var options = new WechatApiClientOptions()
{
    AppId = "微信 AppId",
    AppSecret = "微信 AppSecret",
    MidasAppKey = "米大师相关服务 AppKey，不用则不填",
    ImmeDeliveryAppKey = "即时配送相关服务 AppKey，不用则不填",
    ImmeDeliveryAppSecret = "即时配送相关服务 AppSecret，不用则不填"
};
var client = new WechatApiClient(options);
```

### 请求 & 响应：

```csharp
using SKIT.FlurlHttpClient.Wechat.Api;
using SKIT.FlurlHttpClient.Wechat.Api.Models;

/* 以获取用户信息接口为例 */
var request = new CgibinUserInfoRequest()
{
    AccessToken = "微信 AccessToken",
    OpenId = "微信 OpenId"
};
var response = await client.ExecuteCgibinUserInfoAsync(request);
if (response.IsSuccessful())
{
    Console.WriteLine("昵称：" + response.Nickname);
    Console.WriteLine("头像：" + response.HeadImageUrl);
}
else
{
    Console.WriteLine("错误代码：" + response.ErrorCode);
    Console.WriteLine("错误描述：" + response.ErrorMessage);
}
```

---

## 高级技巧

-   [如何快速找到需要调用的 API 模型类名 / 方法名？](./Advanced_ModelDefinition.md)

-   [如何在 ASP.NET Core 中与 `IHttpClientFactory` 集成？](./Advanced_IHttpClientFactory.md)

-   [如何指定 JSON 序列化器？](./Advanced_JsonSerializer.md)

-   [如何使用拦截器？](./Advanced_Interceptor.md)

-   [如何解析回调通知事件？](./Advanced_EventDataDeserialization.md)

-   [如何验证回调通知事件签名？](./Advanced_EventDataSignatureVerification.md)

-   [如何生成 JS-SDK 初始化时所需的参数及签名？](./Advanced_JSSDK.md)

-   [如何扩展额外的 API？](./Advanced_Extensions.md)

---

## 示例项目

为方便开发者快速掌握本库的使用方法，这里提供一个示例项目以供参考。

请阅读[《示例项目说明》](./Sample.md)。
