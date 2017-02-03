using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int min = getMin(number1, number2, number3);
            Console.WriteLine(min);
        }

        static int getMin(int number1, int number2, int number3)
        {
            if (number1<number2 && number1<number3)
            {
                return number1;
            }
            else if (number2<number1 && number2<number3)
            {
                return number2;
            }
            else
            {
                return number3;
            }
        }
    }
}
