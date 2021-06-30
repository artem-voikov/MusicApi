using Autofac;
using DataEF.Repositories;
using Microsoft.Extensions.Configuration;
using MusicApi.Data.Interfaces;

namespace MusicApi.DataEF.Infrastructure
{
    public class DataEFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MusicEFRepository>().As<IMusicRepository>();
            builder.Register(x => {
                IConfiguration config = new ConfigurationBuilder().AddJsonFile("musicApi.DataEf.settings.json", true, true).Build();
                var settings = new DataEfSettings();
                config.GetSection(DataEfSettings.ConnectionStrings).Bind(settings);
                return settings;

            });

            builder.Register(x => new DataEfContext(x.Resolve<DataEfSettings>())).InstancePerLifetimeScope();
        }
    }
}
