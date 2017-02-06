using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long sumEvens = SumAllevens(number);
            long sumOdds = SumAllOdds(number);
            Console.WriteLine(sumEvens*sumOdds);
        }

        static long SumAllOdds(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            while (number>0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 !=0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        static long SumAllevens(int number)
        {
            number= Math.Abs(number);
            int sum = 0;
            while (number>0)
            {
                int lastDigit = number % 10;
                if (lastDigit %2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
