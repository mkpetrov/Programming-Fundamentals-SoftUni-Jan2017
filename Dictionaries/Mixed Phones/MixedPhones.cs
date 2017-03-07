using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixed_Phones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var output = new SortedDictionary<string, long>();

            while (input !="Over")
            {
                var entry = input
                    .Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                long firstPart;

                var checkForNumber = long.TryParse(entry[0],out firstPart );

                if (checkForNumber==true)
                {
                    output.Add(entry[1], firstPart);
                }
                else
                {
                    long secondPart;
                    var checkSecondPart = long.TryParse(entry[1], out secondPart);
                    output.Add(entry[0], secondPart);
                }

                input = Console.ReadLine();
            }
            foreach (var phoneNUmber in output)
            {
                Console.WriteLine($"{phoneNUmber.Key} -> {phoneNUmber.Value}");
            }
        }
    }
}
