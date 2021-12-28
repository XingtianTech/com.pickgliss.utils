using System;
using Unity.Mathematics;

namespace Pickgliss.Geometry
{
    [Serializable]
    public struct Line2D : IEquatable<Line2D> ,IComparable<Line2D>
    {
        public int2 p0;
        public int2 p1;
        public Line2D (int2 p0, int2 p1)
        {
            this.p0 = p0;
            this.p1 = p1;
        }

        public int CompareTo(Line2D other)
        {
            var length0 = Length();
            var length1 = other.Length();
            if (length0 < length1) {
                return 1;
            }
            if (length0 > length1) {
                return -1;
            }
            return 0;
        }

        public bool Equals(Line2D other)
        {
            return other.p0.Equals(p0) && other.p1.Equals(p1);
        }

        public override string ToString()
        {
            return $"{p0}  {p1}";
        }

        public float Length() => math.distance (p0, p1);
    }
}