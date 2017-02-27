using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camel_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int camelBack = int.Parse(Console.ReadLine());

            var numberToRemove = (numbers.Count - camelBack) / 2;

            var count = 0;

            if (numbers.Count == camelBack)
            {
                Console.Write("already stable: ");
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                for (int i = 0; i < numberToRemove; i++)
                {
                    if (count == numberToRemove)
                    {
                        break;
                    }
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(numbers.Count - 1);
                    count++;
                    i = -1;
                }
                Console.WriteLine($"{count} rounds");
                Console.Write("remaining: ");
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}