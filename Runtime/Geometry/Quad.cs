using System;
using Unity.Mathematics;

namespace Pickgliss.Geometry
{
    [Serializable]
    public struct Quad
    {
        public int3 p0;
        public int3 p1;
        public int3 p2;
        public int3 p3;
        public Quad (int3 p0,int3 p1,int3 p2,int3 p3)
        {
            this.p0 = p0;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Line[] GetOutline()
        {
            var result = new Line [4];
            result[0] = new Line(p0,p1);
            result[1] = new Line(p1,p2);
            result[2] = new Line(p2,p3);
            result[3] = new Line(p3,p0);
            return result;
        }
    }

}