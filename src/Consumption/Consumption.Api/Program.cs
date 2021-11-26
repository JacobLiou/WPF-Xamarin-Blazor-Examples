namespace Consumption.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Consumption.EFCore.Context;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.OpenApi.Writers;
    using NLog.Web;

    /// <summary>
    /// Ӧ�ó��������
    /// </summary>
    public class Program
    {
        /*
        *  �״�������Ŀ��֪:
        *  1.���� appsettings.json �� Connection �����Ƿ��뵱ǰ�Ļ���һ��
        *  
        *  2.��ȷ�� ���ݿ��Ǩ���ļ��Ѿ����µ�������ݿ⵱�С�
        *    2.1. �򿪳�����������̨, ȷ�� Consumption.Api ��ĿΪ������
        *    
        *    2.2. ���ȴ���Ǩ���ļ�,ȷ��Ĭ����Ŀѡ��ΪEfCore  
        *         ����: add-migration firstProjectName
        *         
        *    2.3. Ȼ����������ݿ�  ����: update-database
        *    
        *    2.4. ������Ŀ, ��ҳ��ɹ���ʾOpen API Ԥ��ҳ, ͨ�����ýӿڷ�������,
        *    ����������, ������������ݿⲿ�ֳɹ���
        *    
        *  ע��: ����EfCore ����Ǩ��, �Լ���ν�Ǩ���ļ����ɵ����ݿ⵱��, �漰���˽�EfCore�����֪ʶ
        *  
        *  ���͵�ַ: 
        *  https://www.cnblogs.com/zh7791/p/12931449.html
        *  
        *  ΢��ٷ��ĵ���ַ(������δ���Ǩ�Ʋ����Լ�������Ŀ�������ݿ�):
        *  https://docs.microsoft.com/zh-cn/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
        *   
        */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            try
            {
                var host = CreateHostBuilder(args).Build();
                host.Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        /// <summary>
        /// ��������������
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                     .ConfigureLogging(logging =>
                     {
                         logging.ClearProviders();
                         logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                     }).UseNLog()
                     .UseUrls("http://*:5001");
                });
    }
}
