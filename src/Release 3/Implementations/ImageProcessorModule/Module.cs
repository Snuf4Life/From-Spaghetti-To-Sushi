using ImageProcessingContracts;
using System;

namespace ProcessImageModule
{
    public class Module : IProcessImage
    {
        private readonly IProcessImageProvider[] provider;

        public Module(IProcessImageProvider[] providers)
        {
            this.provider = providers;
        }

        public void GreyScale()
        {
            throw new NotImplementedException();
        }

        public void Resize()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
