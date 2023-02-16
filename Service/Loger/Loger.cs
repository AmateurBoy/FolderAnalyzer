using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FolderAnalyzer.Service.Loger
{
    public static class Logger
    {
        static FileInfo File = new FileInfo(@"C:\Users\march\Desktop\log.txt");
        public static void CreateLog(string logText)
        {
            DateTime dateTime = DateTime.Now;
            var UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string FormatText = $"{dateTime}||{logText}||{UserName}\n";
            using(FileStream FS = new FileStream(File.FullName, FileMode.Append))
            {
                if(FS.Length <= 0)
                {
                    byte[] Pole = new UTF8Encoding(true).GetBytes("DataTime||Log||User\n");
                    FS.Write(Pole, 0, Pole.Length);
                }
                byte[] Text = new UTF8Encoding(true).GetBytes(FormatText);
                FS.Write(Text, 0, Text.Length);
            }
        }
    }
}
