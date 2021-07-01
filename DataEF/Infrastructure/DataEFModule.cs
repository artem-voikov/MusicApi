using Autofac;
using DataEF.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MusicApi.Data.Interfaces;

namespace MusicApi.DataEF.Infrastructure
{
    public class DataEFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MusicEFRepository>().As<IMusicRepository>();
            builder.Register(x => new DataEfContext()).InstancePerLifetimeScope();

        }
    }
}
