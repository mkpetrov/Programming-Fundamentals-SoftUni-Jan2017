using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            numbers.Add(int.MaxValue);

            var count = 1;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                var currentNumber= numbers[i];
                var nextNumber = numbers[i + 1];

                if (currentNumber==nextNumber)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}",currentNumber,count);
                    count = 1;
                }
            }
        }
    }
}
