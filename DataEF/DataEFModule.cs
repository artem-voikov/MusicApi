using Autofac;
using Data.Interfaces;
using DataEF.Repositories;

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
