using ImageProcess;
using ImageProcessContracts;
using ImageProcessContracts.SupportProcesses;
using LogicContract;
using LogicContracts;
using System;
using System.Collections.Generic;

namespace Logic
{
    public class Logic: ILogic, IBuilder
    {
        IProcess _processor;
        public Logic(IProcess processor)
        {
            _processor = processor;
        }

        

        public void Blure(IBuilder provider)
        {
            throw new NotImplementedException();
        }

        public void Build()
        {
            throw new NotImplementedException();
        }

        public IBuilder CreateBuilder()
        {
            throw new NotImplementedException();
        }

        public void Grayscale(IGrayscaleable provider)
        {
            throw new NotImplementedException();
        }

        public void Resize(IResizeable provider)
        {
            throw new NotImplementedException();
        }

        public void UseExtantion(IImageProcessProvider provider)
        {
            throw new NotImplementedException();
        }

        public void Watermark(IWatermarkable provider)
        {
            throw new NotImplementedException();
        }
    }
}
