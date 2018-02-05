using ImageProcessingContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessImageModule
{
    class ImageProcessingFactory : IImageProcessingFactory
    {
        byte[] _image;

        public void SetImageSrc(byte[] imageSrc)
        {
            _image = imageSrc;
        }

        public byte[] GetImage()
        {
            return _image;
        }
    }
}
