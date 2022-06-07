using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace WebJob
{
    internal class Program
    {
        public static async Task Main()
        {
            var host = new HostBuilder()
                .UseEnvironment("Development")
                .ConfigureLogging((context, b) =>
                {
                    b.SetMinimumLevel(LogLevel.Debug);
                    b.AddConsole();
                }).Build();

            await host.RunAsync();
        }
    }
}