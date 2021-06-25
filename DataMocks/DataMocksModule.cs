using Autofac;
using Data.Interfaces;

namespace DataMocks
{
    public class DataMocksModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var dataAccess = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(dataAccess)
                   .Where(t => t.Name.EndsWith("Mock"))
                   .AsImplementedInterfaces();
        }
    }
}
