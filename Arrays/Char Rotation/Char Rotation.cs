using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbols = Console.ReadLine();

            var symbolsToCharrArr = symbols.ToCharArray();

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string text = string.Empty;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2==0)
                {
                    text += (char)(symbolsToCharrArr[i] - numbers[i]);
                }
                if (numbers[i] % 2 !=0)
                {
                    text += (char)(symbolsToCharrArr[i] + numbers[i]);
                }
            }
            Console.WriteLine(text);
        }
    }
}
