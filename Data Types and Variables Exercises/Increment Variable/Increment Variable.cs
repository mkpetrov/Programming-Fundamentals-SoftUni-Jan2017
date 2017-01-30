using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bites=0;
            while (n>255)
            {
                n -= 256;
                bites += 1;
            }
            if (bites>0)
            {
                Console.WriteLine(n);
                Console.WriteLine("Overflowed {0} times",bites);
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }
}
