using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i <number.Length ; i++)
            {
                if (i % 2 !=0 && number[i] % 2 !=0)
                {
                    Console.WriteLine($"Index {i} -> {number[i]}");
                }
            }
        }
    }
}
