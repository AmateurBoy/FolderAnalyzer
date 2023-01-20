using System;
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
        public decimal MdSize = 0;
        const decimal Mb = 9.4297943115234m;
        public MyInfoFloader(DirectoryInfo directories, long size)
        {
            this.directories = directories;
            Size = size;            
        }
        public void BiteToMbite()
        {
            if(Size!=0)
            MdSize = Mb / Size;
        }
    }
}
