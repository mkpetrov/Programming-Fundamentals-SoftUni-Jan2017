using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lastNumber = numbers[1];

            bool equalNumber = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (lastNumber==numbers[i])
                {
                    equalNumber = true;
                }
                else
                {
                    equalNumber = false;
                    break;
                }
            }
            if (equalNumber==true)
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
