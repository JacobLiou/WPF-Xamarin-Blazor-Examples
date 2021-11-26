﻿/*
*
* 文件名    ：ConsumptionResponse                             
* 程序说明  : 请求返回定义类
* 更新时间  : 2020-05-22 14：08
* 联系作者  : QQ:779149549 
* 开发者群  : QQ群:874752819
* 邮件联系  : zhouhaogg789@outlook.com
* 视频教程  : https://space.bilibili.com/32497462
* 博客地址  : https://www.cnblogs.com/zh7791/
* 项目地址  : https://github.com/HenJigg/WPF-Xamarin-Blazor-Examples
* 项目说明  : 以上所有代码均属开源免费使用,禁止个人行为出售本项目源代码
*/


namespace Consumption.Shared.HttpContact.Response
{
    /// <summary>
    /// 请求返回定义类
    /// </summary>
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = "")
        {
            this.StatusCode = statusCode;
            this.Message = message;
        }

        public ApiResponse(int statusCode, object result = null)
        {
            this.StatusCode = statusCode;
            this.Result = result;
        }

        /// <summary>
        /// 后台消息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// //返回状态
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        public object Result { get; set; }
    }
}
