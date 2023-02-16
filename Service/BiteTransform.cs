using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderAnalyzer.Service
{
    public static class BiteTransform
    {
        public static Dictionary<string, double> UnitInfo = new Dictionary<string, double>()
        {
            {"B",0},
            {"kB",1},
            {"mB",2},
            {"gB",3},
            {"tiB",4},
            {"piB",5},
        };
    }
}
