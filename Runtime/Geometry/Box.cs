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

        public int xEnd => x+width;
        public int yEnd => y+height;
        public int zEnd => z+depth;
        public int3 B0 => new int3(x,y,z);
        public int3 B1 => new int3(xEnd,y,z);
        public int3 B2 => new int3(xEnd,y,zEnd);
        public int3 B3 => new int3(x,y,zEnd);
        public int3 T0 => new int3(x,yEnd,z);
        public int3 T1 => new int3(xEnd,yEnd,z);
        public int3 T2 => new int3(xEnd,yEnd,zEnd);
        public int3 T3 => new int3(x,yEnd,zEnd);
        public int3 Position 
        { 
            get => new int3(x,y,z); 
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            } 
        }

        public int3 End
        {
            get => new int3(xEnd,yEnd,zEnd); 
        }
        public int3 Size 
        { 
            get => new int3(width,height,depth); 
            set
            {
                width = value.x;
                height = value.y;
                depth = value.z;
            }  
        }
        public Quad GetQuad(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left : 
                    return new Quad(B0,T0,T3,B3);
                case Direction.Right : 
                    return new Quad(B1,T1,T2,B2);
                case Direction.Front : 
                    return new Quad(B0,T0,T1,B1);
                case Direction.Back : 
                    return new Quad(B3,T3,T2,B2);
                case Direction.Top : 
                    return new Quad(T0,T1,T2,T3);
                case Direction.Bottom : 
                    return new Quad(B0,B1,B2,B3);
            }
            return new Quad();
        }
    }
}
