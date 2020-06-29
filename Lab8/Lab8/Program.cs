using Lab8;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;


namespace Lab8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}




/*
namespace Lab8
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .AddEnvironmentVariables()
             .AddCommandLine(args)
             .AddJsonFile("appsettings.json")
              .Build(); //������ ���� ������������


            var host = new WebHostBuilder()
            .UseKestrel() // ����������� ���-������ Kestrel
            .UseConfiguration(configuration) //��������� ������������
            .UseContentRoot(Directory.GetCurrentDirectory()) // ����������� �������� ������� ����������
            .UseIISIntegration() // ������������ ���������� � IIS
            .UseStartup<Startup>() //������������� ������� ���� ����������
            .ConfigureLogging((hostingContext, logging) => //�������� ��������� ����������������
            {
                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                logging.AddConsole();
                logging.AddDebug();
            }) 
            .Build(); //������ ����
            host.Run();
        }
    }
}
*/
