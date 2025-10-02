using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Prog3
{
    internal class Map
    {
        private int heigt;
        private int width;
        public List<String> map;
        public Map(int heigt, int width)
        {
            this.heigt = heigt;
            this.width = width;
        }

        public void GenerateMap()
        {
            for (int i = 0; i < heigt; i++)
            {
                map.Add("");
                for (int j = 0; j < width; j++)
                {
                    map.Add("");
                }
            }
        }
        public void GenerateMap(List<string> importedMap)
        {
            
        }

        public void GenerateMap(Parc parc)
        {
            
        }
        public int GetHeigt()=>heigt;
        public int GetWidth()=>width;
        
    }
}
