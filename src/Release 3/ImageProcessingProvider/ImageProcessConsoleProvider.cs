using ImageProcessingContracts;
using ImageSharp;
using System;
using System.IO;

namespace ImageProcessingProvider
{
    public class ImageProcessConsoleProvider : IProcessImageProvider
    {

        public void Process(string dest, string path)
        {
            byte[] photoBytes = File.ReadAllBytes(path);
            string name = Path.GetFileNameWithoutExtension(path);
            string target = $@"{dest}\{name}.jpg";
            

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
