using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] numbers = new int[N];

            int countOfNegatives = 0;

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i]<0)
                {
                    countOfNegatives++;
                }
            }
            Console.WriteLine(countOfNegatives);
        }
    }
}
