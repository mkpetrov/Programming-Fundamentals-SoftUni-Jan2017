using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var numberOfLaps = int.Parse(Console.ReadLine());
            var lengthOfTrack = long.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var moneyPerKm = double.Parse(Console.ReadLine());

            runners = Math.Min(capacityOfTrack*marathonDays, runners);

            double totalMeters = runners*numberOfLaps*lengthOfTrack;

            var totalKm = totalMeters / 1000;
            var moneyRaised = totalKm*moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
