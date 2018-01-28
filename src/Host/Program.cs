using Autofac;
using ImageProcessingContracts;
using ImageProcessingProvider;
using LogicContracs;
using LogicModule;
using ProcessImageModule;
using System;
using System.Diagnostics;

namespace Host
{
    static class Program
    {
        static void Main(string[] args)
        {
            var container = Register();
            ILogic logic = container.Resolve<ILogic>();
            var sw = Stopwatch.StartNew();
            logic.Arguments(args);
            sw.Stop();
            Console.WriteLine($"Done: {sw.Elapsed}");
            Console.ReadKey();
        }
        private static IContainer Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Logic>()
                   .As<ILogic>()
                   .SingleInstance();
            builder.RegisterType<ImageProcessModule>()
                  .As<IProcessImage>()
                  .SingleInstance();
            builder.RegisterType<ImageProcessConsoleProvider>()
                  .As<IProcessImageProvider>()
                  .SingleInstance();

            var container = builder.Build();
            return container;
        }
    }
}
