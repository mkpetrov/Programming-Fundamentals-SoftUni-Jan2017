using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            var numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i]>maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
