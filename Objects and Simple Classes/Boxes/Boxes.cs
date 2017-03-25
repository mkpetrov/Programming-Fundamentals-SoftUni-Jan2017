using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        

        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
    public class Box
    {
        public int UpperLeft { get; set; }

        public int UpperRight { get; set; }

        public int BottomLeft { get; set; }

        public int BottomRight { get; set; }  
    }
    class Boxes
    {
        static void Main(string[] args)
        {

        }
    }
}
