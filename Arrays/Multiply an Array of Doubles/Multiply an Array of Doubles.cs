﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
                
            }
            var result = string.Join(" ", numbers);
            Console.WriteLine(result);
        }
    }
}
