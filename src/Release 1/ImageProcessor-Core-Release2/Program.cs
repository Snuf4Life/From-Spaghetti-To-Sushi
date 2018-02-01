using ImageSharp;
using ImageSharp.Colors.Spaces;
using System;
using System.Diagnostics;
using System.IO;

namespace ImageProcessor_Core_Release2
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
            var sw = Stopwatch.StartNew();
            foreach (var path in paths)
            {
                ProcessImage(dest, path);
            }

            sw.Stop();
            Console.WriteLine($"Done: {sw.Elapsed}");
            Console.ReadKey();
        }

        private static void ProcessImage(string dest, string path)
        {
            byte[] photoBytes = File.ReadAllBytes(path);
            string name = Path.GetFileNameWithoutExtension(path);
            string target = $@"{dest}\{name}.jpg";
            Console.WriteLine(name);

            using (var outStream = new FileStream(target, FileMode.Create))
            {

                var image = new Image(photoBytes);
                image.MaxHeight = 600;
                image.MaxWidth = 600;
                image.Resize(image.MaxHeight, image.MaxHeight)
                     .Grayscale()
                     .Save(outStream);
            }
        }
    }
}
