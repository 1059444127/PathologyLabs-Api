using AutoMapper.Attributes;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace PathologyLabs.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            AutoMapper.Mapper.Initialize(config => {
                typeof(Program).Assembly.MapTypes(config);
            });
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
