using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FolderAnalyzer.Service
{
    public class FolderManager : IDisposable
    {
        public readonly string Path;
        public List<MyInfoFloader> directories = new List<MyInfoFloader>();
        public int SecretFloader = 0;
        public async Task Run()
        {
            if (!String.IsNullOrWhiteSpace(Path))
            {
                SecretFloader = 0;
                WorkFind(Path);
            }            
        }
        public FolderManager(string path)
        {
            Path = path;            
        }
        public MyInfoFloader WorkFind(string path)
        {
            
            MyInfoFloader floader = null;
            long res = 0;
            try
            {                
                DirectoryInfo directoryInfo = new DirectoryInfo(path); // 1.Получить текущию папку.
                floader = new MyInfoFloader(directoryInfo, res);    // Создать екземпляр папки.
                var TopDirectory = directoryInfo.GetDirectories("*.*",SearchOption.TopDirectoryOnly).ToList(); //2.Получить дочерние папки.
                var ThisFileDirectory = directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly).ToList(); //3.Получить файлы текущей папки.

                foreach (var directory in TopDirectory) //Получения дочерней папки с собсвенім размером.
                {
                    MyInfoFloader myInfoFloader = WorkFind(directory.FullName);
                    floader.Size += myInfoFloader.Size;            
                }                
                foreach (var file in ThisFileDirectory)
                {
                    floader.Size += file.Length;
                }
                directories.Add(floader);
                return floader;
            }
            catch
            {
                SecretFloader += 1;
                return floader;
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
        public List<string> TopSizeFloaders(int count,string unit)
        {

            List<string> strings = new List<string>();
            var result = directories.OrderByDescending(x => x.Size).ToList();
            int i = 0;
            foreach (var item in result)
            {
                if (i < count)
                {
                    var info = new InfoDTO(item.directories.FullName, item.ConvertBite(unit));
                    string Json = JsonConvert.SerializeObject(info);
                    strings.Add(Json);
                }
                    
                else
                    break;
                i++;
            }
            return strings;
           
        }
        public int GetCountSecret()
        {
            return SecretFloader;
        }

        public void Dispose()
        {
            directories = null;
        }
    }
}
