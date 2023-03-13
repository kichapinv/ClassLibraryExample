using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTasks
{
    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public static Vector Add(Vector vector1, Vector vector2)
        {
            Vector result = new Vector();
            result.X = vector1.X + vector2.X;
            result.Y = vector1.Y + vector2.Y;
            return result;
        }
        public static double GetLength(Segment segment)
        {
            double segmentX = Math.Pow((segment.End.X - segment.Begin.X), 2);
            double segmentY = Math.Pow((segment.End.Y - segment.Begin.Y), 2);
            return Math.Sqrt(segmentX + segmentY);
        }

        public static bool IsVectorInSegment(Vector vector, Segment segment)
        {
            Segment segmentAC = new Segment();
            segmentAC.End = vector;
            segmentAC.Begin = segment.Begin;
            double lengthSegmentAC = GetLength(segmentAC);

            Segment segmentBC = new Segment();
            segmentBC.End = vector;
            segmentBC.Begin = segment.End;
            double lengthSegmentBC = GetLength(segmentBC);
            
            double lengthSegment = GetLength(segment);

            return lengthSegment == lengthSegmentAC + lengthSegmentBC;
        }
    }
}
