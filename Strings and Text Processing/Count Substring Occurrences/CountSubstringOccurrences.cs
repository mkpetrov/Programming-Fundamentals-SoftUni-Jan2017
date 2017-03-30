using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var wordToCount = Console.ReadLine().ToLower();

            int counter = 0;
            int index = input.IndexOf(wordToCount);

            while (index !=-1)
            {
                counter++;
                index = input.IndexOf(wordToCount, index + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
