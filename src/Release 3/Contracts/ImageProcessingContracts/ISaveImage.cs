using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessingContracts
{
   public interface ISaveImage
    {
        void SaveJPG(byte[] imageSrc, string target);
    }
}
