using Enums;
using ImageProcessingContracts;
using System;

namespace ProcessImageModule
{
    public class ImageProcessModule : IProcessImage
    {
        private readonly IProcessImageProvider[] provider;

        public ImageProcessModule(IProcessImageProvider[] providers)
        {
            this.provider = providers;
        }

        public byte[] GreyScale(byte[] imageSrc)
        {
            throw new NotImplementedException();
        }      

        public byte[] Resize(byte[] imageSrc)
        {
            throw new NotImplementedException();
        }

        public void Save(SaveDestanations Dest, byte[] imageSrc)
        {
            throw new NotImplementedException();
        }
    }
}
