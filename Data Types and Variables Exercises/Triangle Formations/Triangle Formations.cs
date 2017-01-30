using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a+b>c && a+c>b && b+c>a)
            {
                Console.WriteLine("Triangle is valid.");
                if (a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b)
                {
                    if (a > b && a > c)
                    {
                        Console.WriteLine("Triangle has a right angle between sides b and c");
                    }
                    if (b > a && b > c)
                    {
                        Console.WriteLine("Triangle has a right angle between sides a and c");
                    }
                    if (c > a && c > b)
                    {
                        Console.WriteLine("Triangle has a right angle between sides a and b");
                    }
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
            
        }
    }
}
