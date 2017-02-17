using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var squareNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (Math.Sqrt(number)==(int)(Math.Sqrt(number)))
                {
                    squareNumbers.Add(number);
                }
            }
            squareNumbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",squareNumbers));
        }
    }
}
