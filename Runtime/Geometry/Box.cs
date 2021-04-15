using System;
using System.Collections.Generic;
using Unity.Mathematics;

namespace Pickgliss.Geometry
{
    [Serializable]
    public struct Box
    {
        public int x;
        public int y;
        public int z;
        public int width;
        public int height;
        public int depth;
        
        public Box(int x,int y,int z, int width,int height,int depth)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
        public Box(int3 position,int3 size) : this(position.x,position.y,position.z,size.x,size.y,size.z){}
        public Box(Rect rect,int height,int floor = 0) : this(rect.x,floor,rect.y,rect.width,height,rect.height){}
    }
}
