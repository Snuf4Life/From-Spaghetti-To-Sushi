﻿using Enums;
using ImageProcessingContracts;
using LogicContracs;
using System.IO;

namespace LogicModule
{
    public class Logic : ILogic
    {
        private readonly IProcessImage _processor;
        public Logic(IProcessImage processor)
        {
            _processor = processor;
        }     
           
        public void ImagePath(params string[] paths)
        {
            foreach (var path in paths)
            {
                ProcessImageFromPath(path);
            }
        }

        private void ProcessImageFromPath(string path)
        {
            byte[] photoBytes = File.ReadAllBytes(path);
            photoBytes =  _processor.GreyScale(photoBytes);
            photoBytes = _processor.Resize(photoBytes);
            _processor.Save(SaveDestanations.Disk, photoBytes);           
        }
    }
}