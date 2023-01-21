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
        public static Dictionary<string,double> UnitInfo = new Dictionary<string, double>()
        {
            {"B",0},
            {"kB",1},
            {"mB",2},
            {"gB",3},
            {"tiB",4},
            {"piB",5},
        };
        public DirectoryInfo directories;
        public long Size = 0;
        
        public MyInfoFloader(DirectoryInfo directories, long size)
        {
            this.directories = directories;
            Size = size;  
            
        } 
        public double ConvertBite(string Unit)
        {
            double result = 0;
            result = Size / Math.Pow(1024,UnitInfo[Unit]);
            return result;
        }        
    }
}
