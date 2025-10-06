using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_Prog3.Util;

namespace TP2_Prog3
{
    public class Map
    {
        private static string txtPath = Path.Combine(Environment.CurrentDirectory, "map.txt");
        private static readonly List<string> ImportedMap = FileReader.ReadFile(txtPath);
   
        public List<String> map = new List<String>();
        public Map(int heigt, int width)
        {
            GenerateMap();
        }
        
        private void GenerateMap()
        {
            
            for (int i = 0; i < ImportedMap.Count; i++)
            {
                map.Add(ImportedMap[i]);
                
            }
        }
        
        
    }
}
