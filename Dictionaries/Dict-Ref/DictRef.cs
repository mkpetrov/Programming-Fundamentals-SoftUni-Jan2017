using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var outup = new Dictionary<string, long>();

            while (input !="end")
            {
                var entry = input
                    .Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var key = entry[0];
                int value ;

                var checkNumber =Int32.TryParse(entry[1], out value);

                if (checkNumber==true)
                {
                    if (!outup.ContainsKey(key))
                    {
                        outup.Add(key, value);
                    }
                }
                else
                {
                    if (!outup.ContainsKey(entry[1]))
                    {

                        outup[key] = outup[entry[1]];
                    }
                    
                }

                input = Console.ReadLine();
            }
            foreach (var item in outup)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
