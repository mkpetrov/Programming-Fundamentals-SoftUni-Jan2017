using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                printLine(i);
            }

            for (int i = n-1; i >= 1; i--)
            {
                printLine(i);
            }
        }

        static void printLine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
