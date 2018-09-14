

using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Threading;
using DamaCoreCMS.Framework.Core.App;
using System.Diagnostics;
using DamaCoreCMS.Framework.Utility;
using DamaCoreCMS.Framework.Setup;

namespace DamaCoreCMS.Web
{
    public class Program
    {
        private static IWebHost nccWebHost;
        private static Thread starterThread = new Thread(StartApp);
        
        public static void Main(string[] args)
        {
            DamaCoreCMSHost.StartForerver(starterThread, new ParameterizedThreadStart(StartApp), Directory.GetCurrentDirectory(), args);
        }

        private static void StartApp(object argsObj)
        {
            BuildWebHost((string[])argsObj).Run();            
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            nccWebHost = WebHost.CreateDefaultBuilder(args)
                .UseKestrel(c => c.AddServerHeader = false)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseDefaultServiceProvider(options => options.ValidateScopes = false)
                .UseApplicationInsights()
                .Build();
            return nccWebHost;
        }

        public static async Task RestartAppAsync()
        {
            DamaCoreCMSHost.StopAppAsync(nccWebHost);            
        }

        public static async Task ShutdownAppAsync()
        {
            DamaCoreCMSHost.ShutdownAppAsync(nccWebHost);
        }
    }
}
