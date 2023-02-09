using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderAnalyzer
{
    public class InfoDTO
    {
        public string Name { get; set; }
        public double Size { get; set; }
        public InfoDTO(string name, double size)
        {
            Name = name;
            Size = size;
        }
    }
}
