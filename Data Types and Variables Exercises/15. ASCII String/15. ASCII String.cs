using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string text = string.Empty;
            for (int i = 0; i < N; i++)
            {
                int asciiNumber = int.Parse(Console.ReadLine());
                var word = Convert.ToChar(asciiNumber);
                text += word;
            }
            Console.WriteLine(text);
        }
    }
}
