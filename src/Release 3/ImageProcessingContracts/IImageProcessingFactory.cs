using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessingContracts
{
    interface IImageProcessingFactory
    {
        void setImageSrc(byte[] imageSrc);
    }
}
