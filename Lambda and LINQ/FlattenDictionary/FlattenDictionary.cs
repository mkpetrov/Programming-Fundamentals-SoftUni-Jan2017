using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var result = new Dictionary<string, Dictionary<string, string>>();

            while (inputLine != "end")
            {
                var input = inputLine.Split(' ');
                

                if (input[0] != "flatten")
                {
                    var key = input[0];
                    var innerKey = input[1];
                    var innerValue = input[2];
                    if (!result.ContainsKey(key))
                    {
                        result[key] = new Dictionary<string, string>();
                    }
                    result[key][innerKey] = innerValue;
                }
                else
                {
                    result[input[1]] = result[input[1]]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                inputLine = Console.ReadLine();
            }
            var keysOrdered = result
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in keysOrdered)
            {
                Console.WriteLine("{0}",entry.Key);

                var innerOrder = entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedKeys=entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;

                foreach (var thing in innerOrder)
                {
                    Console.WriteLine("{0}. {1} - {2}", count, thing.Key, thing.Value);

                    count++;
                }

                foreach (var thing in flattenedKeys)
                {
                    Console.WriteLine("{0}. {1} ", count, thing.Key);

                    count++;
                }
            }
        }
    }
}
