using Experimental.System.Messaging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Fundoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MessageQueue Myqueue;
            Myqueue = new MessageQueue(@".\private$\Myqueue");
             Myqueue.Receive();
           CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
