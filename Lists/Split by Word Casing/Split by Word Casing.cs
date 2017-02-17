using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
                                  StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            var lowerLetters = 0;
            var upperLetters = 0;

            for (int i = 0; i < words.Count; i++)
            {
                var wordToCheck = words[i];
                foreach (var letter in wordToCheck)
                {
                    if (letter>=97 && letter<=122)
                    {
                        lowerLetters++;
                    }
                    if (letter>=65 && letter<=90)
                    {
                        upperLetters++;
                    }
                }
                if (lowerLetters==wordToCheck.Length)
                {
                    lowerCase.Add(wordToCheck);
                }
                if (upperLetters==wordToCheck.Length)
                {
                    upperCase.Add(wordToCheck);
                }
                else if (lowerLetters!=wordToCheck.Length && upperLetters!=wordToCheck.Length)
                {
                    mixedCase.Add(wordToCheck);
                }
                lowerLetters = 0;
                upperLetters = 0;
                
            }

            Console.Write("Lower-case: ");
            Console.WriteLine(string.Join(", ", lowerCase));
            Console.Write("Mixed-case: ");
            Console.WriteLine(string.Join(", ", mixedCase));
            Console.Write("Upper-case: ");
            Console.WriteLine(string.Join(", ", upperCase));
        }
    }
}
