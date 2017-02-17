using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double .Parse).ToList();

            var lastNumber = 0.0;

            var sumNumbers = 0.0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (lastNumber==numbers[i])
                {
                    sumNumbers=lastNumber+numbers[i];
                    numbers.Remove(numbers[i-1]);
                    numbers[i-1] = sumNumbers;
                    i = 0;
                }
                lastNumber = numbers[i];
                
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
