using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessingContracts
{
    public interface IProcessImage
    {
        void ProcessImage(string dest, string path);
    }
}
