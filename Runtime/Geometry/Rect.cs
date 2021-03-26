using System;
using System.Collections.Generic;
using Unity.Mathematics;

namespace Pickgliss.Geometry
{
    [Serializable]
    public struct Rect
    {
        public Rect (int x,int y,int width,int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public Rect (int2 p1,int2 p2)
        {
            x = math.min(p1.x,p2.x);
            y = math.min(p1.y,p2.y);
            width = math.abs(p1.x-p2.x);
            height = math.abs(p1.y-p2.y);
        }

        public bool Contains(int2 p) => Contains(p.x,p.y);
        public bool Contains(int px, int py)
        {
            if (Left < px && Bottom < py && Right > px && Top > py)
            {
                return true;
            }
            return false;
        }

        public bool CollidesWith(Rect rect)
        {
            if(rect.Left >= Right ||
                rect.Bottom >= Top ||
                rect.Right <= Left ||
                rect.Top <= Bottom)
            {
                return false;
            }
            return true;
        }

        public int x;
        public int y;
        public int width;
        public int height;

        public int2 LeftBottom => new int2(Left,Bottom);
        public int2 RightBottom => new int2(Right,Bottom);
        public int2 LeftTop => new int2(Left,Top);
        public int2 RightTop => new int2(Right,Top);

        public int Left => x;
        public int Right => x + width;
        public int Bottom => y;
        public int Top => y + height;

        public int CenterX => x + width/2;
        public int CenterY => y + height/2;
        public int2 Center //=> new int2(CenterX,CenterY);
        {
            get => new int2(CenterX,CenterY);
            set
            {
                x = value.x - width/2;
                y = value.y - height/2;
            }
        }

        public int2 Position 
        { 
            get => new int2(x,y); 
            set
            {
                x = value.x;
                y = value.y;
            } 
        }
        public int2 Size 
        { 
            get => new int2(width,height); 
            set
            {
                width = value.x;
                height = value.y;
            }  
        }

        public override string ToString()
        {
            return x+","+y+","+width+","+height;
        }
    }
}