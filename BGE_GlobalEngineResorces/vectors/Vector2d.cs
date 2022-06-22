using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGE_GlobalEngineResorces.vectors
{
    public class Vector2d //são vetores
    {
        public int x; //variavel 1
        public int y; //variavel 2

        public Vector2d(int x, int y) //construtor TOP
        {
            this.x = x;
            this.y = y;
        }
        public Vector2d() //construtor vazio
        {

        }
        public int[] return_array() //return Array
        {
            int[] A = {this.x, this.y};
            return A;
        }
    }
}
