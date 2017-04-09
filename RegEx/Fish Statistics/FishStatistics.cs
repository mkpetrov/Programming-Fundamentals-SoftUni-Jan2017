using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Fish_Statistics
{
    
    class FishStatistics
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var regex = new Regex(@"(>*)<(\(+)('|x|-)>");

            var matches = regex.Matches(inputLine);

            var validFishes = regex.IsMatch(inputLine);

            var count = 1;

            foreach (Match match in matches)
            {
                var TheFish = match.Value;
                var Tail = match.Groups[1].Length;
                var Body = match.Groups[2].Length;

                var status = match.Groups[3].Value;

                Console.WriteLine("Fish {0}: {1}",count,TheFish);
                if (Tail>5)
                {
                    Console.WriteLine("  Tail type: Long ({0} cm)",Tail*2);
                }
                else if (Tail>1 && Tail<=5)
                {
                    Console.WriteLine("  Tail type: Medium ({0} cm)",Tail*2);
                }
                else if (Tail==1)
                {
                    Console.WriteLine("  Tail type: Short ({0} cm)", Tail * 2);
                }
                else if (Tail==0)
                {
                    Console.WriteLine("  Tail type: None");
                }

                if (Body>10)
                {
                    Console.WriteLine("  Body type: Long ({0} cm)",Body*2);
                }
                else if (Body>5 && Body<=10)
                {
                    Console.WriteLine("  Body type: Medium ({0} cm)", Body * 2);
                }
                else if (Body<=5)
                {
                    Console.WriteLine("  Body type: Short ({0} cm)", Body * 2);
                }

                if (status=="'")
                {
                    Console.WriteLine("  Status: Awake");
                }
                else if (status=="-")
                {
                    Console.WriteLine("  Status: Asleep");
                }
                else if (status=="x")
                {
                    Console.WriteLine("  Status: Dead");
                }

                count++;
            }
            if (!validFishes)
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
