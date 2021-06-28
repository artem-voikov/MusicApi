using Autofac;
using DataMocks;

namespace MusicApi
{
    internal class StartupWithMocks : Startup
    {
        protected override void RegisterDataSource(ContainerBuilder builder)
        {
            builder.RegisterModule<DataMocksModule>();
        }
    }
}