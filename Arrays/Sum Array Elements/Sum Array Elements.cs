﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());
                sum += numbers[i]; 
            }
            Console.WriteLine(sum);
        }
    }
}
