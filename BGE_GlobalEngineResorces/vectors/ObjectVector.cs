using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGE_GlobalEngineResorces.vectors
{
    public class ObjectVector
    {
        public Vector2d Size = new Vector2d(1, 1);
        public Vector2d Position = new Vector2d(0, 0);
        public int Rotation = 0;
        public Space2d Space;

        public ObjectVector(Space2d space)
        {
            Space = space;
        }
        public ObjectVector(Vector2d size, Vector2d position, int rotation, Space2d space)
        {
            Size = size;
            Position = position;
            Rotation = rotation;
            Space = space;
        }
        public ObjectVector(Vector2d size, Vector2d position, Space2d space)
        {
            this.Size = size;
            this.Position = position;
            this.Space = space;
        }
    }
}
