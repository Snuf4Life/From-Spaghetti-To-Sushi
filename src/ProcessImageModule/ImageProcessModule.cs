using ImageProcessingContracts;
using System;

namespace ProcessImageModule
{
    public class ImageProcessModule : IProcessImage
    {
        private readonly IProcessImageProvider provider;

        public ImageProcessModule(IProcessImageProvider providers)
        {
            this.provider = providers;
        }

        public void ProcessImage(string dest, string path)
        {
            provider.Process(dest, path);
        }
    }
}
