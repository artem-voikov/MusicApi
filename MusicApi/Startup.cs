using Autofac;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MusicApi.DataEF.Infrastructure;
using NLog;
using NLog.Extensions.Logging;
using System;
using System.IO;

namespace MusicApi
{
    public class Startup
    {
        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplication8", Version = "v1" });
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            RegisterDataSource(builder);
            builder.Register(x => new ConfigurationBuilder()
               .SetBasePath(System.IO.Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .Build());
            builder.RegisterModule<DomainModule>();
            builder.Register<IMapper>(x =>
            {
                var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddMaps(
                    "MusicApi.Domain", "MusicApi.Representation", "MusicApi.DataEF"));
                return new Mapper(mapperConfiguration);
            });
            builder.Register(x => new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables().Build());

            builder.Register(x => LogManager.Setup().LoadConfigurationFromSection(x.Resolve<IConfigurationRoot>()).GetCurrentClassLogger()).As<ILogger>();
        }

        protected virtual void RegisterDataSource(ContainerBuilder builder)
        {
            builder.RegisterModule<DataEFModule>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApplication8 v1"));
            }

            app.UseStatusCodePages();
            app.UseRouting();
            app.UseMiddleware<ExceptionHandlingMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
            });
        }
    }
}
