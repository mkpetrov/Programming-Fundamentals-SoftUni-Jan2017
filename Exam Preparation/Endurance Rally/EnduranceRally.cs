using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endurance_Rally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            var driversName = Console.ReadLine().Split(' ');
            var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var checkpoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var driver in driversName)
            {
                double fuel = driver[0]-0;

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoint.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }

                    if (fuel<=0)
                    {
                        Console.WriteLine("{0} - reached {1}",driver,i);
                        break;
                    }
                }
                if (fuel>0)
                {
                    Console.WriteLine("{0} - fuel left {1:f2}", driver, fuel);
                }
            }
        }
    }
}
