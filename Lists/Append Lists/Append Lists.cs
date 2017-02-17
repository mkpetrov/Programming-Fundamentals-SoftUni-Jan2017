using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToArray();

            var result = new List<string>();

            Array.Reverse(input);

            foreach (var token in input)
            {
                string[] numbers = token.Split(' ');
                foreach (var number in numbers)
                {
                    if (number != " ")
                    {
                        result.Add(number);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
