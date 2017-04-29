using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            var wingsFlaps = long.Parse(Console.ReadLine());
            var distancePer1000Flaps = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var distance = (wingsFlaps / 1000) * distancePer1000Flaps;

            var time = (wingsFlaps / 100) + ((wingsFlaps / endurance) * 5);

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{time} s.");
        }
    }
}
