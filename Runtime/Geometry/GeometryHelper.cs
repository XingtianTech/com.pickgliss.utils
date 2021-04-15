using System.Collections.Generic;
using Unity.Mathematics;

namespace Pickgliss.Geometry
{
    using UnityEngine;
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

        public static List<Line2D> GetOutline(Plane plane)
        {
            var result = new List<Line2D>(4);
            // result.Add(new Line2D(rect.LeftBottom,rect.LeftTop));
            // result.Add(new Line2D(rect.LeftTop,rect.RightTop));
            // result.Add(new Line2D(rect.RightTop,rect.RightBottom));
            // result.Add(new Line2D(rect.RightBottom,rect.LeftBottom));
            return result;
        }

        public static Line2D? GetLinkedJoint(Rect r1 ,Rect r2)
        {
            var joint = new Line2D();
            if(r1.Left == r2.Right)
            {
                if(r1.Bottom > r2.Top || r2.Bottom > r1.Top)return null;
                joint.p0.x = joint.p1.x = r1.Left;
                joint.p0.y = math.max(r1.Bottom,r2.Bottom);
                joint.p1.y = math.min(r1.Top,r2.Top);
            }
            else if(r1.Right == r2.Left)
            {
                if(r1.Bottom > r2.Top || r2.Bottom > r1.Top)return null;
                joint.p0.x = joint.p1.x = r1.Right;
                joint.p0.y = math.max(r1.Bottom,r2.Bottom);
                joint.p1.y = math.min(r1.Top,r2.Top);

            }else if(r1.Bottom == r2.Top)
            {
                if(r1.Left > r2.Right || r2.Left > r1.Right)return null;
                joint.p0.y = joint.p1.y = r1.Bottom;
                joint.p0.x = math.max(r1.Left,r2.Left);
                joint.p1.x = math.min(r1.Right,r2.Right);

            }else if(r1.Top == r2.Bottom)
            {
                if(r1.Left > r2.Right || r2.Left > r1.Right)return null;
                joint.p0.y = joint.p1.y = r1.Top;
                joint.p0.x = math.max(r1.Left,r2.Left);
                joint.p1.x = math.min(r1.Right,r2.Right);
            }else
            {
                return null;
            }
            return joint;
        }
    }
}