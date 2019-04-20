using Autofac;
using AutofacProject.Concrets;
using AutofacProject.Interfaces;

namespace AutofacProject.Autofac
{
    class ConfigAutofac
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            RergisterTypes(builder);

            return builder.Build();
        }

        private static void RergisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();
            builder.RegisterType<Logger>().As<ILogger>().SingleInstance();
        }
    }
}
