using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace Pickgliss.Geometry
{
    public static class GeometryHelper
    {
        public static List<Line2D> GetOutline(Rect rect)
        {
            var result = new List<Line2D>(4);
            result.Add(new Line2D(rect.LeftBottom,rect.LeftTop));
            result.Add(new Line2D(rect.LeftTop,rect.RightTop));
            result.Add(new Line2D(rect.RightTop,rect.RightBottom));
            result.Add(new Line2D(rect.RightBottom,rect.LeftBottom));
            return result;
        }

        public static Line2D GetRectConnected(Rect r1,Rect r2)
        {
            Line2D line = new Line2D();
            if(r1.Left == r2.Right)
            {
                line.p0.x = line.p1.x = r1.Left;
                line.p0.y = math.max(r1.Bottom,r2.Bottom);
                line.p1.y = math.min(r1.Top,r2.Top);
            }
            else if(r1.Right == r2.Left)
            {
                line.p0.x = line.p1.x = r1.Right;
                line.p0.y = math.max(r1.Bottom,r2.Bottom);
                line.p1.y = math.min(r1.Top,r2.Top);

            }else if(r1.Bottom == r2.Top)
            {
                line.p0.y = line.p1.y = r1.Bottom;
                line.p0.x = math.max(r1.Left,r2.Left);
                line.p1.x = math.min(r1.Right,r2.Right);

            }else if(r1.Top == r2.Bottom)
            {
                line.p0.y = line.p1.y = r1.Top;
                line.p0.x = math.max(r1.Left,r2.Left);
                line.p1.x = math.min(r1.Right,r2.Right);
            }else
            {
                Debug.LogWarning("GetRectConnected Rect No connections");
            }
            return line;
        }
    }
}