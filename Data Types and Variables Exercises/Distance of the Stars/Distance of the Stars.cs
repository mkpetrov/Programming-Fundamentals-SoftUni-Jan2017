using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_of_the_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double nearestStar = 4.22;
            int centerOfGalaxy = 26000;
            int milkyWay = 100000;
            long edgeOfUniverse = 46500000000;
            long lightYear = 9450000000000;

            Console.WriteLine("{0:e2}",nearestStar*lightYear);
            Console.WriteLine("{0:e2}",centerOfGalaxy*lightYear);
            Console.WriteLine("{0:e2}",milkyWay*lightYear);
            Console.WriteLine("{0:e2}",edgeOfUniverse*(decimal)lightYear);
        }
    }
}
