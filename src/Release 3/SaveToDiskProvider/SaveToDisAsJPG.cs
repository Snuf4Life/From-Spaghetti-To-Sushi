using System;
using System.IO;
using ImageProcessingContracts;
using SixLabors.ImageSharp;

namespace SaveToDiskProvider
{
    public class SaveToDisAsJPG : ISaveImage
    {
        public void SaveJPG(byte[] imageSrc,string target)
        {
            using (var outStream = new FileStream(target, FileMode.Create))
            using (Image<Rgba32> image = Image.Load(imageSrc))
            {
                image.SaveAsJpeg(outStream);
            }
        }

       
    }
}
