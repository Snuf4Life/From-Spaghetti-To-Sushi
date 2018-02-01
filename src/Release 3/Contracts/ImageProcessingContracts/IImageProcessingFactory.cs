using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessingContracts
{
   public interface IImageProcessingFactory
    {
        void setImageSrc(byte[] imageSrc);
    }
}
