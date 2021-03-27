using Pickgliss.Geometry;
using System.Collections.Generic;
using UnityEngine;

namespace Pickgliss.Helper
{
    public static class DebugHelper
    {
        public static void DrawLine2D(Line2D line,Color color)
        {
            Debug.DrawLine(new Vector3(line.p0.x,0,line.p0.y),new Vector3(line.p1.x,0,line.p1.y),color);
        }

        public static void DrawLine2D(List<Line2D> lines,Color color)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                DrawLine2D(lines[i],color);
            }
        }
    }
}