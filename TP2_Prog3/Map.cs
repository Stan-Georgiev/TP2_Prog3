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
        public int GetHeigt()=>heigt;
        public int GetWidth()=>width;
        
    }
}
