using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Distance_Between_Points
{
    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }
    }

    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            var result = Distance(firstPoint, secondPoint);

            Console.WriteLine($"{result:f3}");
        }
        public static double Distance(Point first,Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);
            var result = Math.Sqrt(squareX + squareY);
            return result;
        }

        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
    }
}
