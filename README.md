## 介绍（Description）
MvcPager for ASP.NET Core Mvc 2.X & 3.X

## 安装（Install）

1. nuget：Install-Package HeyCoder.AspNetCore.MvcPager
2. CLI：dotnet add package HeyCoder.AspNetCore.MvcPager
3. https://www.nuget.org/packages/HeyCoder.AspNetCore.MvcPager

## 配置（Config）

- Startup.cs

```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IPagerOption, PagerOption>();
}
```

- appsettings.json

```json
{
  "HeyCoder.MvcPager": {
    "PageSize": "10",
    "PageButtonCount": "10",
    "PagerClassName": "pager",
    "CurrentPageClassName": "active",
    "PrePageButtonText": "&lt;",
    "NextPageButtonText": "&gt;",
    "PreGroupButtonText": "&lt;&lt;",
    "NextGroupButtonText": "&gt;&gt;",
    "FirstPageButtonText": "首页",
    "LastPageButtonText": "尾页",
    "ShowPagerStatus": "true",
    "ShowPreNextPageButton": "true",
    "ShowFirstLastPageButton": "false",
    "ShowGotoPanel": "true",
    "ShowDataCount": "true",
    "CurrentPageInCenter": "true",
    "DataCountTextFormat": "共{0}条数据",
    "PagerStatusTextFormat": "共{1}页"
  }
}


```
 wiki:https://github.com/heycoder/mvcpager.core/wiki


## 使用示例（Demo）

1. Theme:Default
```
<link href="//cdn.ken.io/plugin/mvcpager/theme/default-1.0.css" rel="stylesheet"/>

@Html.Pager(new {p = Guid.NewGuid().ToString()}, new PagerOption(){ PageIndex = Model.PageIndex })
```
2. Theme:BootStrap
```
<link href="//cdn.bootcss.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" />
<link href="//cdn.ken.io/plugin/mvcpager/theme/bootstrap-1.0.css" rel="stylesheet" />


@Html.Pager(new {p = Guid.NewGuid().ToString()}, new PagerOption(){ PageIndex = Model.PageIndex })
```

## 项目成员（Members）

#### ken

- 邮箱（Email）：m#ken.io
- 博客（Blog）：https://ken.io
