using Autofac;
using CommandLineParserNuget;
using ImageProcessingContracts;
using ImageProcessingProvider;
using LogicContracs;
using LogicModule;
using ProcessImageModule;
using System;
using System.Diagnostics;
using System.IO;

namespace Host
{
    static class Program
    {
        static void Main(string[] args)
        {
            var argsParser = new CommandLineParser(args);
            string src = argsParser["src"];
            string dest = argsParser["dest"];
            dest = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                dest,
                                DateTime.Now.ToString("HH-mm-ss"));
            if (!Directory.Exists(dest))
                Directory.CreateDirectory(dest);

            var paths = Directory.GetFiles(src);

            var container = Register();
            ILogic logic = container.Resolve<ILogic>();
            var sw = Stopwatch.StartNew();
            logic.ImagePath(paths);
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
          

            var container = builder.Build();
            return container;
        }
    }
}
