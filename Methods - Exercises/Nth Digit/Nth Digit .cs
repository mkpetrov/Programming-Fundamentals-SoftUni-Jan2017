using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            var findDigit = FindNthDigit(number,index);
            Console.WriteLine(findDigit);
        }

        static int FindNthDigit(long number, int index)
        {
            int currentIndex =0;
            int Nnumber = 0;
            while (number>0)
            {
                currentIndex += 1;
                if (currentIndex==index)
                {
                    Nnumber += (int)number % 10;
                    
                }
                else
                {
                    
                    number = number / 10;
                    
                }
                
            }
            return Nnumber;
        }
    }
}
