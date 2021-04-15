using System;
namespace Pickgliss.Geometry
{
    [Flags]
    public enum Direction : int
    {
        None = 0,
        Left = 1 << 0,
        Right = 1 << 1,
        Front = 1 << 2,
        Back = 1 << 3,
        Bottom = 1 << 4,
        Top = 1 << 5,
        
    }

    [Flags]
    public enum Direction2D : int
    {
        None = 0,
        Left = Direction.Left,
        Right = Direction.Right,
        Front = Direction.Front,
        Back = Direction.Back,
    }
}