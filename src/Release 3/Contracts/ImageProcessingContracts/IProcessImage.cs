using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessingContracts
{
    public interface IProcessImage
    {        
        void GreyScale();
        void Resize();
        void Save();
    }
}
