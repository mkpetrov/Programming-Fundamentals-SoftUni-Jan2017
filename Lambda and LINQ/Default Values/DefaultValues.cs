using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Values
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var defVal= new Dictionary<string, string>();

            while (inputLine != "end")
            {
                var token = inputLine
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var key = token[0];
                var value = token[1];

                defVal[key] = value;
                
                inputLine = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var unchangedValues = defVal
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            var changedValues = defVal
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x=>defaultValue);

            foreach (var value in unchangedValues)
            {
                Console.WriteLine("{0} <-> {1}",value.Key,value.Value);
            }

            foreach (var word in changedValues)
            {
                Console.WriteLine("{0} <-> {1}", word.Key, word.Value);
            }

        }
    }
}
