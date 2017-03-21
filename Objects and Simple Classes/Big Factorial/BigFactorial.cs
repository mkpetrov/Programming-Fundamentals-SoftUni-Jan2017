using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Big_Factorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            var n= int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
