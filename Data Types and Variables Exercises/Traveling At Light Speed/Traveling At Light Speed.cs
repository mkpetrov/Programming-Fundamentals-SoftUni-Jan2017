using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveling_At_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ly = decimal.Parse(Console.ReadLine());
            decimal lyInKm = 9450000000000;
            decimal lSpeedSec = 300000;
            decimal total = (lyInKm / lSpeedSec) * ly;
            decimal weeks = total / 60 / 60 / 24 / 7;
            decimal day = total / 60 / 60 / 24 % 7;
            decimal Hours = total / 60 / 60 % 24;
            decimal Minutes = total / 60 % 60;
            decimal Seconds = total % 60;
            Console.WriteLine("{0} weeks", Math.Round(weeks));
            Console.WriteLine("{0} days", Math.Round(day));
            Console.WriteLine("{0} hours", Math.Round(Hours));
            Console.WriteLine("{0} minutes", Math.Round(Minutes));
            Console.WriteLine("{0} seconds", Math.Round(Seconds));
        }
    }
}
