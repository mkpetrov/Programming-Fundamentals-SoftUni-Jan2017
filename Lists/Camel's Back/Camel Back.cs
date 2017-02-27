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

            var numbersToRemove = (numbers.Count - camelBack) / 2;

            var count = 0;

            for (int i = 0; i < numbersToRemove; i++)
            {
                if (count==numbersToRemove)
                {
                    break;
                }
                numbers.RemoveAt(i);
                numbers.RemoveAt(numbers.Count - 1);
                count++;
                i = 0;
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
