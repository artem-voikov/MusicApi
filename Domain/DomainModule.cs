using Autofac;
using Domain.Interfaces;
using Domain.Services;

namespace Domain
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MusicService>().As<IMusicService>();
        }
    }
}
