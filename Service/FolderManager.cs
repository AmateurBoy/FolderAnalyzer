using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderAnalyzer.Service
{
    public class FolderManager
    {
        public readonly string Path;
        public List<MyInfoFloader> directories = new List<MyInfoFloader>();
        
        public FolderManager(string path)
        {
            Path = path;            
        }
        public async Task<long> Run(string path)
        {
            long res = 0;
            try
            {
                
                DirectoryInfo directoryInfo = new DirectoryInfo(path);                
                var TopDirectory = directoryInfo.GetDirectories("*.*",SearchOption.TopDirectoryOnly).ToList();
                
                foreach (var directory in TopDirectory) 
                {
                    MyInfoFloader MIF = new MyInfoFloader(directory, 0);
                    res += await Run(directory.FullName);
                    MIF.Size = res;
                    MIF.BiteToMbite();
                    directories.Add(MIF);
                }
                var ThisFileDirectory = directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly).ToList();
                foreach (var file in ThisFileDirectory)
                {
                   res += file.Length;
                }
                return res;
            }
            catch
            {
                return res; 
            }
        }
        public long ResultSize()
        {
            long result = 0;
            foreach (var floader in directories)
            {
               result += floader.Size;
            }
            return result;
        }
        public List<string> Top10SizeFloaders()
        {
            List<string> strings = new List<string>();
            var result = directories.OrderByDescending(x => x.Size).ToList();
            int count = 0;
            foreach (var item in result)
            {
                if (count < 11)
                    strings.Add($"Name:{item.directories.FullName} Size:{item.Size}");
                else
                    break;
                count++;
            }
            return strings;
           
        }
        
    }
}
