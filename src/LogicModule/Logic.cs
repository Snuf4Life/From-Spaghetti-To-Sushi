using CommandLineParserNuget;
using ImageProcessingContracts;
using LogicContracs;
using System;
using System.Diagnostics;
using System.IO;

namespace LogicModule
{
    public class Logic : ILogic
    {
        private readonly IProcessImage _processor;
        public Logic(IProcessImage processor)
        {
            _processor = processor;
        }
        public void Arguments(string[] args)
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

            
            foreach (var path in paths)
            {
                _processor.ProcessImage(dest, path);
            }

           
        }
    }
}
