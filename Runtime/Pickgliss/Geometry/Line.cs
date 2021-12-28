using System;
using Unity.Mathematics;

namespace Pickgliss.Geometry
{
    [Serializable]
    public struct Line : IEquatable<Line> ,IComparable<Line>
    {
        public int3 p0;
        public int3 p1;
        public Line (int3 p0, int3 p1)
        {
            this.p0 = p0;
            this.p1 = p1;
        }

        public int CompareTo(Line other)
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

        public bool Equals(Line other)
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