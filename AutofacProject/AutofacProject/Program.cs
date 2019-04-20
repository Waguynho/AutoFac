using Autofac;
using AutofacProject.Autofac;
using AutofacProject.Interfaces;
using System;

namespace AutofacProject
{
    class Program
    {
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {

            Container = ConfigAutofac.GetContainer();

            ILogger loggerSingleton1 = Container.Resolve<ILogger>();//By resolver

            loggerSingleton1.ShowInConsole(string.Format("start program: {0}", loggerSingleton1.GetHashCode()));

            WriteDate();

            Console.Read();
        }

        public static void WriteDate()
        {
            ILogger logger2 = Container.Resolve<ILogger>();
            logger2.ShowInConsole(string.Format("begin write date: {0}", logger2.GetHashCode()));

            // Create the scope, resolve your IDateWriter,
            // use it, then dispose of the scope.
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>(); 
                
                writer.WriteDate();

                logger2.ShowInConsole(string.Format("write date instance 1: {0}", writer.GetHashCode()));
            }

            IDateWriter writer2 = Container.Resolve<IDateWriter>();

            logger2.ShowInConsole(string.Format("write date instance 2: {0}", writer2.GetHashCode()));
        }
    }
}
