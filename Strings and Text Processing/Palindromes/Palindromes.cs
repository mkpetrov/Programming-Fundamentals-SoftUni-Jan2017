using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var output = new List<string>();

            foreach (var kvp in input)
            {
                var reversedKVP = new string(kvp.Reverse().ToArray());
                if (reversedKVP==kvp)
                {
                    output.Add(kvp);
                }
            }
            output.Sort();
            Console.WriteLine(string.Join(", ",output));
        }
    }
}
