using ImageProcessingContracts;
using SixLabors.ImageSharp;
using System;

namespace ReSizeProvider
{
    public class ReSize :IProcessImageProvider
    {
        public byte[] Process(byte[] imageSrc)
        {
            using (Image<Rgba32> image = Image.Load(imageSrc))
            {
                image.Mutate(x => x
                     .Resize(600,600));
                return image.SavePixelData();
            }
        }
    }
}
