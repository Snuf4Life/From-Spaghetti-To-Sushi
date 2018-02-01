using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessingContracts
{
   public interface IProcessImageProvider
    {
        byte[] Process(byte[] imageSrc);
    }
}
