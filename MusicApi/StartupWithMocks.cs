using Autofac;
using DataMocks;
using Microsoft.Extensions.Configuration;

namespace MusicApi
{
    internal class StartupWithMocks : Startup
    {
        public StartupWithMocks(IConfiguration configuration) : base(configuration)
        {
        }

        protected override void RegisterDataSource(ContainerBuilder builder)
        {
            builder.RegisterModule<DataMocksModule>();
        }
    }
}