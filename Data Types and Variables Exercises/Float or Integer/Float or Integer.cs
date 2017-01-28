using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            if (number%1==0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(Math.Round(number));
            }
        }
    }
}
