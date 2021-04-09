using System;
namespace Pickgliss.Geometry
{
    [Flags]
    public enum Direction2D : int
    {
        All = -1,
        None = 0,
        Left = 1 << 0,
        Right = 1 << 1,
        Front = 1 << 2,
        Back = 1 << 3,
    }

}