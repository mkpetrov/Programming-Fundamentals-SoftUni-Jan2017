using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double N = double.Parse(Console.ReadLine());

            int countBiggerThanN = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>N)
                {
                    countBiggerThanN++;
                }
            }
            Console.WriteLine(countBiggerThanN);
        }
    }
}
