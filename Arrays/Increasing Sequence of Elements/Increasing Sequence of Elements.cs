using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lastNumber = 0;

            bool bigger = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (lastNumber<numbers[i])
                {
                    bigger = true;
                }
                else
                {
                    bigger = false;
                    break;
                }
                lastNumber = numbers[i];
            }
            if (bigger==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
