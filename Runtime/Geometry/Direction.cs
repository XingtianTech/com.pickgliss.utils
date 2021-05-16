using System;
using System.Collections.Generic;
using System.Linq;

namespace Pickgliss.Geometry
{
    [Flags]
    public enum Direction : int
    {
        None = 0,
        Left = 1 << DirectionIndex.Left,
        Right = 1 << DirectionIndex.Right,
        Front = 1 << DirectionIndex.Front,
        Back = 1 << DirectionIndex.Back,
        Bottom = 1 << DirectionIndex.Bottom,
        Top = 1 << DirectionIndex.Top,
        Walls = Left | Right | Front | Back,
    }

    public enum DirectionIndex : int
    {
        Left = 0,
        Right = 1,
        Front = 2,
        Back = 3,
        Bottom = 4,
        Top = 5,
    }

    public enum Direction2D : int
    {
        Left = Direction.Left,
        Right = Direction.Right,
        Front = Direction.Front,
        Back = Direction.Back,
    }

    public static class DirectionExtension
    {
        public static IEnumerable<Direction2D> GetFlags(this Direction2D input)
        {
            foreach (Direction2D value in Enum.GetValues(input.GetType()))
            if (input.HasFlag(value))
                yield return value;
        }

        public static IEnumerable<Direction> GetFlags(this Direction input)
        {
            foreach (Direction value in Enum.GetValues(input.GetType()))
            if (input.HasFlag(value))
                yield return value;
        }
    }
}