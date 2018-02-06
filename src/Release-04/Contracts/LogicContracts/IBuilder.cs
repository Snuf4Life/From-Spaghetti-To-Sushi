using ImageProcessContracts;
using ImageProcessContracts.SupportProcesses;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicContracts
{
   public interface IBuilder
    {
        List<IImageProcessProvider> _providersTobuild { set; }
        void Grayscale (IGrayscaleable provider);
        void Resize (IResizeable provider);
        void Blure(IBuilder provider);
        void Watermark(IWatermarkable provider);
        void UseExtantion(IImageProcessProvider provider);
        void Build();
        IImageProcess Execute();

    }
}
