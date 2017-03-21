using System;
using System.Collections.Generic;
using System.Linq;

namespace Closest_Two_Points
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int i = 0; i < points.Count; i++)
            {
                for (int k = i+1; k < points.Count; k++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[k];
                    var distance = Distance(firstPoint, secondPoint);

                    if (distance<minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
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

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);
            var result = Math.Sqrt(squareX + squareY);
            return result;
        }
    }
}
