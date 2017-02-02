using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double result = RiseToPower(num1, num2);
            Console.WriteLine(result);
        }

        static double RiseToPower(double num1, double num2)
        {
            double result = Math.Pow(num1, num2);

            return result;
        }
    }
}
