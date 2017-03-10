using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var shellsInfo = new Dictionary<string, List<int>>();

            var sumShells = 0;

            while (input != "Aggregate")
            {
                var currentShell = input.Split();
                var region = currentShell[0];
                var shellSize = int.Parse(currentShell[1]);
                sumShells += shellSize;
               
                if (!shellsInfo.ContainsKey(region))
                {
                    shellsInfo[region] = new List<int>();
                }
                if (!shellsInfo[region].Contains(shellSize))
                {
                    shellsInfo[region].Add(shellSize);
                }

                input = Console.ReadLine();
            }

            foreach (var location in shellsInfo)
            {
                var region = location.Key;
                var shells = location.Value;

                var giantShell = shells.Sum() - shells.Sum() / shells.Count;

                Console.WriteLine($"{region} -> {string.Join(", ",shells)} ({giantShell})");
            }
        }
    }
}
