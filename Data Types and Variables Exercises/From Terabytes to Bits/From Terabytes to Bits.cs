using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal terabytes = decimal.Parse(Console.ReadLine());
            decimal bits = 8796093022208m;
            Console.WriteLine("{0:f0}",terabytes*bits);
        }
    }
}
