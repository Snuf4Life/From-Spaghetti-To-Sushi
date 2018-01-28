using System;
using System.Collections.Generic;
using System.Text;

namespace ImageProcessingContracts
{
   public interface IProcessImageProvider
    {
        void Process(string dest, string path);
    }
}
