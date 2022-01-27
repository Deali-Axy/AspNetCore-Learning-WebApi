﻿## Asp.Net Core学习之WebApi

相关项目：[Asp.Net Core学习 MVC版](https://github.com/Deali-Axy/AspNetCore-Learning-Mvc)

公众号 | 公众号 |
------- | ------ | 
![](https://gitee.com/deali/CodeZone/raw/master/images/coding_lab_logo.jpg) | ![](https://gitee.com/deali/CodeZone/raw/master/images/coding_lab_qr_code.jpg)   |

Asp.Net Core 学习笔记系列博客：

- [Asp.Net Core学习笔记：入门篇](https://zhuanlan.zhihu.com/p/105443116)
- [Asp.Net Core学习笔记：（二）视图、模型、持久化、文件、错误处理、日志](https://zhuanlan.zhihu.com/p/105953794)
- [Asp.Net Core学习笔记：（三）使用SignalR实时通信框架开发聊天室](https://zhuanlan.zhihu.com/p/106321863)
- [Asp.Net Core学习笔记：（四）Blazor WebAssembly入门](https://zhuanlan.zhihu.com/p/107262924)

C#语言学习系列博客：

- [C#学习（一）委托的概念和使用](https://zhuanlan.zhihu.com/p/101040936)
- [C#学习（二）匿名方法和委托的多种使用方式](https://zhuanlan.zhihu.com/p/101116276)
- [C#学习（三）深入理解委托、匿名方法和 Lambda 表达式](https://zhuanlan.zhihu.com/p/101178999)

相关博文推荐：

- [花一周时间整理的六千字长文！深入思考技术本质，跨平台开发框架AspNetCore的简单实践杂谈](https://zhuanlan.zhihu.com/p/267938409)
- [在.NET Core(C#)中使用EPPlus.Core导出Excel文档](https://zhuanlan.zhihu.com/p/261750807)
- [NetCore爬虫：CatSpider# 开发笔记](https://zhuanlan.zhihu.com/p/106015789)

## 认证与授权

### 认证

身份认证处理程序是实现身份认证操作的核心类，身份认证处理程序派生自接口`IAuthenticationHandler`。该接口定义了以下三种操作：身份认证（`AuthenticateAsync`）、挑战（`ChallengeAsync`）和禁止（`ForbidAsync`）。其中，身份认证是主要的操作。

身份认证返回AuthenticateResult来表明该请求的身份认证是否成功，`AuthenticateResult`可以返回三种类型的结果：失败（`Fail`）、无结果（`NoResult`）和成功（`Success`）。如果验证成功，将会通过`AuthenticateResult`返回`AuthenticationTicket`。`AuthenticationTicket`将会封装用户信息，以便于在后续的授权中使用。

挑战是指当前请求访问的资源要求身份认证，但是当前请求未通过身份认证，那么后续的授权阶段就需要通过指定的身份认证方案中的身份认证处理程序来提供挑战方法，以便发起挑战。如果没有指定身份认证方案，就会使用默认身份认证方案。举个例子来说，如果我们因为长时间没有操作而导致系统登录会话超时失效，那么再次对系统进行操作时，系统一般会将页面重定向到登录页面，这个重定向的操作就是一种挑战。

禁止是指已经通过身份认证的用户尝试访问其无权访问的资源时而进入授权阶段所要执行的操作。比如某站点的普通用户想要使用VIP用户的功能，如果该用户没有登录，那么本次请求就是匿名访问，这时授权阶段需要发起挑战操作；如果该用户已经登录，但是授权阶段发现该用户没有权限访问该资源，那么系统可能会返回HTTP 403状态码，这种返回HTTP 403状态码的操作就是一种禁止。

#### 用户信息模型

身份认证通过后，身份认证处理程序会返回身份认证票根，即`AuthenticationTicket`。

`AuthenticationTicket`是ASP.NET Core封装认证信息的类。

`AuthenticationTicket`又包含了`ClaimsPrincipal`，`ClaimsPrincipal`可以理解为用户主体，由一组`ClaimIdentity`组成。

`ClaimsIdentity`可以理解为身份证明，一个用户主体可以有多个身份证明，就好比身份证、驾驶证都可以代表唯一具体的人一样。

`ClaimsIdentity`包含了一组`Claim`，`Claim`就是好比身份证上的姓名、性别、籍贯等信息。一个用户通过身份认证后，就会用以上类来组织用户信息。后续的授权等其他中间件就可以使用这些信息来进行功能设计。

结构示例如下：

- `AuthenticationTicket` （身份认证票根，其中封装了认证信息）
  - `ClaimsPrincipal` （用户主体）
    - `ClaimIdentity` （身份证明）
      - `Claim`
      - `Claim`
      - `Claim`
    - `ClaimIdentity`
    - `ClaimIdentity`

### 授权

授权（`Authorization`）决定了一个用户在系统里能干什么。对于ASP.NET Core应用来说，授权决定了一个用户能够访问哪些资源路径。授权与7.1节讲的身份认证是依赖和被依赖的关系，ASP.NETCore将身份认证与授权设计成了相对独立的两个功能模块，两个模块的职责分工非常明确，前者解决用户是谁的问题，后者解决用户能干什么的问题。从功能上来看，授权是基于身份认证的结果而做出的，从逻辑上来说，只有知道用户是谁才能确定用户能干什么。

ASP.NET Core提供了简单授权、基于角色的授权、基于策略的授权，多样的授权方式在通过简单的`Attribute`修饰就能满足大部分应用场景。授权中重要的两个`Attribute`就是`AuthorizeAttribute`和`AllowAnonymousAttribute`，所有的授权配置都离不开这两个`Attribute`。同时，ASP.NET Core对授权方案的扩展也非常方便，在本节的最后会介绍如何自定义授权处理程序来实现自定义授权逻辑。

授权有这三种类型

- 简单授权：只要登录就能访问，在`Controller`或者`Action`上加个`[Authorize]`就行
- 基于角色的授权：特定角色能访问
- 基于策略的授权：顾名思义

#### 基于角色的授权

基于角色的授权简单来说就是一个资源必须要指定角色的用户才能够访问。基于角色的授权必须在Controller或Action上指定哪些角色可以访问该资源。

`AuthorizeAttribute`有一个公开的string类型的属性Roles。通过这个属性可以指定哪些角色可以访问特定资源。认证用户是否属于某个角色可以通过`ClaimsPrincipal`类的`IsInRole`方法进行验证，ASP.NET Core基于角色的授权就是通过这个方法来确定当前用户是否属于某个角色用户的。当前用户属于角色属性如何设置呢？很简单，`ClaimsIdentity`的属性`RoleClaimType`会告诉ASP.NET Core哪个`Claim`存储了用户的角色信息。

比如某个Controller需要管理员角色才能访问：

```c#
[Authorize(Roles="管理员")]
```

可以指定多个角色都可以访问，多个角色间用逗号分隔：

```c#
[Authorize(Roles="人力经理,财务")]
```

如果用多个`[Authorize(Roles='SomeRole')]`修饰`Controller`或`Action`，那么访问的用户必须是所有指定角色的成员，下面的例子必须同时是“销售”和“经理”才能访问

```c#
[Authorize(Roles="销售")]
[Authorize(Roles="经理")]
```

#### 基于策略的授权

基于策略的授权是更灵活的授权方式，我们先来了解ASP.NET Core的授权模型。与身份认证相似，ASP.NET Core由授权处理程序、授权需求、授权方案、授权服务构成。其中，授权服务同身份认证服务一样，作为授权服务接口对外提供授权能力。授权方案是组织授权机制的概念，一个授权方案可以包含多个授权需求，只有满足了所有授权需求才算通过了授权方案，而授权需求可以关联多个授权处理程序，任意一个授权处理程序返回授权成功，则表示该授权方案下的授权需求被满足了。

ASP.NET Core提供了一个授权策略，实现了建造者模式，通过AuthorizationPolicyBuilder可以方便地构建AuthorizationPolicy。基于AuthorizationPolicyBuilder，可以方便地设置授权策略的授权需求。

```c#
services.AddAuthorization(config => {
    config.AddPolicy("RequireAdmin", builder => builder.RequireRole("管理员"));
});
```

除了AuthorizeAttribute上可以设置的角色外，还可以设置Claim需求。

该授权策略需要当前认证用户姓"赵"：

```c#
services.AddAuthorization(config => {
    config.AddPolicy("RequireZhao", builder => builder.RequireClaim("姓", "赵"));
});
```

如果被授权的姓氏规则比较复杂，不利于枚举出来，那么推荐使用RequireAssertion来实现。比如上面的功能还可以用如下方式来实现：

```c#
services.AddAuthorization(config => {
    config.AddPolicy("RequireZhao", builder => builder.RequireAssertion(
        context => context.User.FindFirst("姓").Value=="赵"));
});
```

除此之外，还可以通过实现了IAuthorizationRequirement的授权需求来关联自定义的授权处理程序来实现更灵活的授权规则设计。

### IdentityServer4

IdentityServer4是ASP.NET Core平台下的一个OAuth 2.0以及OpenID Connect的实现。它非常方便地提供了身份认证、授权以及第三方认证服务对接，并且支持自定义方式来满足开发者不同场景下各式各样的需求。IdentityServer4作为一个成熟的认证授权框架，是受到OpenID Connect官方认证的服务端实现。IdentityServer开源且免费，在重视知识产权的今天，我们可以放心地基于IdentityServer4搭建认证平台开发商业应用。

IdentityServer通过IdentityResource、ApiScope、ApiResource、Client这些概念来实现身份的认证和资源的权限控制。

IdentityResource是指用户ID、姓名、手机号等用户信息，比如OpenID Connect规范就定义了一组标准的IdentityResource。除此之外，我们也可以自定义IdentityResource，这些概念很像ASP.NETCore中身份认证的Claim，定义了程序能访问到的用户信息。

ApiScope可以认为是API的一种标签，而ApiResource就是对API在授权场景下的抽象。如果需要对客户端能否访问某个API进行控制，就要定义ApiScope和ApiResource。

Client通过Request Token限制了哪些应用可以访问对应的API资源。每个Client都会有一个唯一的Client ID，通过设置一个秘钥可以加强用户信息安全性，关键的是通过设置AllowedApiScopes，框架就可以控制这个Client可以访问哪些ApiResource（Resource是和Scope相关联的）。



## 版本说明

- [v0.1](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.1)
  实现生成假数据的增删改查功能
- [v0.2](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2)
  实现与数据库交互的增删改查功能
- [v0.2.1](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2.1)
  实现简单分页功能
- [v0.2.2](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2.2)
  实现分页元数据
- [v0.2.3](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2.3)
  实现作者过滤和搜索功能
- [v0.2.4](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2.4)
  实现作者排序（多字段、正排倒排）功能
- [v0.2.5](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2.5)
  完成日志配置+异常过滤器
- [v0.2.6](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2.6)
  实现Http缓存功能
- [v0.2.7](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2.7)
  `BookController.UpdateBookAsync()` 加入简单的开放式并发控制功能
- [v0.2.8](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.2.8)
  实现HATEOAS
- [v0.3](https://github.com/Deali-Axy/AspNetCore-Learning/tree/v0.3)
  实现JwtBearerToken认证+EFCore后端