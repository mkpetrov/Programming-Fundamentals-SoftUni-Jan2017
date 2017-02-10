using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int smallestNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                var currNumber = numbers[i];
                if (currNumber<smallestNumber)
                {
                    smallestNumber = currNumber;
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
