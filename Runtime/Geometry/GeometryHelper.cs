using System.Collections.Generic;

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
    }
}