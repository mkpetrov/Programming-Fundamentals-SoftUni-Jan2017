using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var sumChars = 0;

            var countChars = 0;

            for (int i = 0; i < input.Count; i++)
            {
                input[i].ToCharArray();
                foreach (var word in input[i])
                {
                    sumChars += Convert.ToInt32(word);
                    countChars++;
                }
            }

            var delimiter = sumChars / countChars;
            if (delimiter>=97 && delimiter<=122)
            {
                var charForDelimiter = (char)(delimiter);
                var upperCase=Char.ToUpper(charForDelimiter);
                Console.WriteLine(string.Join($"{upperCase}",input));
            }
            else
            {
                var chaForDelimiter = (char)(delimiter);
                Console.WriteLine(string.Join($"{chaForDelimiter}",input));
            }

        }
    }
}
