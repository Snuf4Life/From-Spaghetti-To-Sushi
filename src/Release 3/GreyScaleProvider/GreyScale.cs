using ImageProcessingContracts;
using SixLabors.ImageSharp;
using System;

namespace GreyScaleProvider
{
    public class GreyScale : IProcessImageProvider
    {
        public byte[] Process(byte[] imageSrc)
        {
            using (Image<Rgba32> image = Image.Load(imageSrc))
            {
                image.Mutate(x => x                    
                     .Grayscale());
                return image.SavePixelData();
            }
        }
    }
}
