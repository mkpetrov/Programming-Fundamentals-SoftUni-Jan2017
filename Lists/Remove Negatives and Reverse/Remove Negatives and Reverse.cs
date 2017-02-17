using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var positiveNumbers =new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]>0)
                {
                    positiveNumbers.Add(numbers[i]);
                }
                
            }
            positiveNumbers.Reverse();
            if (positiveNumbers.Count==0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var number in positiveNumbers)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
