﻿# CHANGELOG

---

<details>

<summary>SKIT.FlurlHttpClient.Wechat 更新日志</summary>

-   Release 1.1.0

    -   **变更**：引入 SKIT.FlurlHttpClient.Common 依赖，并废弃相关公共组件。

-   Release 1.0.3

    -   **修复**：显式依赖 `System.Text.Encodings.Web`，修复部分场景下程序集加载问题。（[Gitee Issue #I42V13](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I42V13)）

-   Release 1.0.2

    -   **新增**：新增 `IWechatClient.JsonSerializer` 属性。

-   Release 1.0.1

    -   **变更**：移除 `IWechatClient.CreateRequest()` 方法。

-   Release 1.0.0

    -   首次发布。

</details>

---

<details>

<summary>SKIT.FlurlHttpClient.Wechat.Api 更新日志</summary>

-   Release 1.7.0

    -   **新增**：新增小程序检查加密信息是否由微信生成的接口。

    -   **新增**：新增小程序发送统一消息的接口。（[GitHub Issue #6](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/6)）

    -   **新增**：新增 AES 解密工具类。

-   Release 1.6.0

    -   **新增**：新增小程序发送订阅消息的接口。（[Gitee Issue #I47D5T](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I47D5T)）

    -   **变更**：调整 `IXmlSerializable`、`IJsonSerializable` 接口定义。

-   Release 1.5.0

    -   **变更**：升级核心库。

    -   **修复**：修复潜在的 XXE 漏洞风险。

-   Release 1.4.1

    -   **修复**：修复部分场景下生成微信回调通知事件签名错误的问题。（[GitHub Issue #4](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/4)）

-   Release 1.4.0

    -   **新增**：新增第三方平台代云开发相关接口。

    -   **新增**：随官方更新内容安全相关字段。

-   Release 1.3.5

    -   **修复**：修复获取图文素材接口模型的字段缺失问题。（[Gitee Issue #I43QPI](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I43QPI)）

-   Release 1.3.4

    -   **修复**：修复安全模式下反序列化微信回调通知事件的问题。

-   Release 1.3.3

    -   **新增**：新增验证微信回调通知事件签名的扩展方法。

-   Release 1.3.2

    -   **新增**：反序列化微信回调通知事件模型时支持 `WechatApiEvent` 基类，以便业务逻辑判断。

-   Release 1.3.1

    -   **修复**：修复自定义交易组件获取快递公司列表接口的模型定义错误。（[Gitee Issue #I43AM2](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I43AM2)）

-   Release 1.3.0

    -   **新增**：新增序列化回调通知事件实体类的扩展方法。

    -   **新增**：反序列化微信回调通知事件模型时支持安全模式。

    -   **修复**：修复部分微信回调通知事件模型反序列化的问题。

-   Release 1.2.1

    -   **修复**：修复生成小程序码接口的模型定义错误。（[Gitee Issue #I42XC0](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I42XC0)）

-   Release 1.2.0

    -   **新增**：新增 `WechatApiClient.Credentials` 属性。

    -   **变更**：移除 `WechatApiClient.FlurlJsonSerializer` 属性。

-   Release 1.1.0

    -   **新增**：新增小程序获取用户加密 Key 相关接口。

    -   **新增**：新增小程序生成 ShortLink 相关接口。

-   Release 1.0.1

    -   **新增**：新增 `WechatApiClient.CreateRequest()` 方法。

-   Release 1.0.0

    -   首次发布。

</details>

---

<details>

<summary>SKIT.FlurlHttpClient.Wechat.TenpayV3 更新日志</summary>

-   Release 1.8.0

    -   **新增**：随官方更新消费者投诉接口相关字段。

    -   **新增**：新增消费者投诉下载图片相关接口。

-   Release 1.7.0

    -   **变更**：升级核心库。

-   Release 1.6.0

    -   **新增**：新增银行定向促活相关接口。

-   Release 1.5.4

    -   **修复**：修复特约商户进件提交申请单接口请求模型定义错误的问题。（[Gitee Issue #I45RRM](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45RRM)）

-   Release 1.5.2

    -   **修复**：修复特约商户进件提交申请单接口因 URL 结尾反斜杠问题而无法正常请求的问题。（[Gitee Issue #I45QFY](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45QFY)）

-   Release 1.5.1

    -   **修复**：修复部分接口模型因继承问题在使用 System.Text.Json 时序列化有误的问题。（[Gitee Issue #I45C27](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I45C27)）

-   Release 1.5.0

    -   **新增**：新增微信支付分停车服务相关接口。

    -   **新增**：随官方更新电商分账、连锁品牌分账接口相关字段。

-   Release 1.4.2

    -   **变更**：验证响应或回调通知签名时不再抛出异常。

-   Release 1.4.0

    -   **新增**：新增获取分账账单相关接口。

    -   **新增**：随官方更新分账、服务商分账接口相关字段。

    -   **新增**：新增 `WechatTenpayV3Client.Credentials` 属性。

    -   **变更**：移除 `WechatTenpayV3Client.FlurlJsonSerializer` 属性。

    -   **变更**：移除 `ICertificateStorer` 接口，新增 `CertificateManager` 抽象类。

    -   **修复**：修复部分场景下生成请求签名的错误。（[GitHub Issue #2](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/2)）

-   Release 1.3.1

    -   **新增**：新增批量转账到零钱相关接口。

    -   **新增**：新增服务商批量转账到零钱相关接口。

    -   **新增**：新增 `ICertificateStorer` 接口，并基于此重新实现验签的扩展方法。（[GitHub Issue #1](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/1)）

-   Release 1.2.1

    -   **新增**：新增 `WechatTenpayV3Client.CreateRequest()` 方法。

-   Release 1.2.0

    -   **变更**：调整包含需加解密字段的接口模型，去除 _EncryptedData_ 的字段名结尾。

-   Release 1.1.0

    -   **新增**：新增分账相关接口。

-   Release 1.0.1

    -   **新增**：随官方更新服务商提现、服务商结算账户接口相关字段。

    -   **修复**：修复调起支付所需参数签名生成错误。（[Gitee Issue #I3YY2C](https://gitee.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/I3YY2C)）

-   Release 1.0.0

    -   首次发布。

</details>

---

<details>

<summary>SKIT.FlurlHttpClient.Wechat.Work 更新日志</summary>

-   Release 1.3.2

    -   **修复**：修复创建或获取通讯录成员时的请求模型定义错误。（[GitHub Issue #8](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/8)）

-   Release 1.3.1

    -   **修复**：修复获取服务商凭证接口请求模型定义错误。（[GitHub PR #5](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/pull/5)）

-   Release 1.3.0

    -   **新增**：新增通讯录异步导出相关接口。

    -   **新增**：新增获取选人 Ticket 对应的用户相关接口。

    -   **新增**：新增客户联系规则组相关接口。

    -   **新增**：新增客户朋友圈规则组相关接口。

    -   **新增**：新增获取学校应用可使用的家长范围相关接口。

    -   **新增**：随官方更新获取群聊数据统计数据接口相关字段。

    -   **新增**：随官方更新企业通讯录接口相关字段。

    -   **新增**：随官方更新客户标签回调通知事件回调模型。

    -   **新增**：随官方更新企业客户回调通知事件回调模型。

    -   **变更**：升级核心库。

    -   **修复**：修复潜在的 XXE 漏洞风险。

-   Release 1.2.3

    -   **修复**：修复部分场景下生成微信回调通知事件签名错误的问题。（[GitHub Issue #4](https://github.com/fudiwei/DotNetCore.SKIT.FlurlHttpClient.Wechat/issues/4)）

-   Release 1.2.2

    -   **新增**：新增序列化回调通知事件实体类的扩展方法。

    -   **新增**：反序列化企业微信回调通知事件模型时支持安全模式。

    -   **修复**：修复部分企业微信回调通知事件模型反序列化的问题。

-   Release 1.2.0

    -   **新增**：新增 `WechatWorkClient.Credentials` 属性。

    -   **变更**：移除 `WechatWorkClient.FlurlJsonSerializer` 属性。

-   Release 1.1.0

    -   **新增**：随官方更新客户联系接口相关字段。

    -   **新增**：新增班级收款相关接口。

-   Release 1.0.1

    -   **新增**：新增 `WechatWorkClient.CreateRequest()` 方法。

    -   **新增**：新增企业微信小程序相关接口。

-   Release 1.0.0

    -   首次发布。

</details>
