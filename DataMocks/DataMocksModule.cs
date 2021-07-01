using Autofac;
using MusicApi.Data.Interfaces;

namespace DataMocks
{
    public class DataMocksModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MusicRepositoryMock>().As<IMusicRepository>();
        }
    }
}
