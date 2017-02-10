using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int countOdds = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 !=0)
                {
                    countOdds += 1;
                }
            }
            Console.WriteLine(countOdds);
        }
    }
}
