﻿using Mbc.Log4Tc.Plugin;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Mbc.Log4Tc.Output.NLog
{
    public class NLogLog4TcOutputPlugin : IPlugin
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IOutputFactory, NLogLog4TcOutputFactory>();
        }
    }
}
