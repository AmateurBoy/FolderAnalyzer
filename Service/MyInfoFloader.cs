﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderAnalyzer.Service
{
    
    public class MyInfoFloader
    {                
        public DirectoryInfo directories;
        public long Size = 0;
        public int countsecret = 0;

        public MyInfoFloader(DirectoryInfo directories, long size)
        {
            this.directories = directories;
            Size = size;            
        } 
        public double ConvertBite(string Unit)
        {
            double result = 0;
            result = Size / Math.Pow(1024,BiteTransform.UnitInfo[Unit]);
            return result;
        }        
    }
}
