using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGE_GlobalEngineResorces.vectors
{
    public class Space2d
    {
        public Vector2d Size = new Vector2d();

        public Space2d(Vector2d size)
        {
            Size = size;
        }
        public Space2d(int X, int Y)
        {
            Vector2d vector = new Vector2d(X, Y);
            Size = vector;
        }
    }
}
