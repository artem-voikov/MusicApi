using Autofac;
using DataEF.Repositories;
using MusicApi.Data.Interfaces;

namespace DataEF
{
    public class DataEFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MusicEFRepository>().As<IMusicRepository>();
        }
    }
}
