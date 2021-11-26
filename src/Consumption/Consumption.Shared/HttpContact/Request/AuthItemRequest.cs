﻿/*
*
* 文件名    ：AuthItemRequest                             
* 程序说明  : 获取功能按钮请求
* 更新时间  : 2020-07-11 18：13
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/

using Consumption.Shared.HttpContact;

namespace Consumption.Core.Request
{
    /// <summary>
    /// 获取功能按钮请求
    /// </summary>
    public class AuthItemRequest : BaseRequest
    {
        public override string route { get => "api/AuthItem/GetAll"; }
    }
}
