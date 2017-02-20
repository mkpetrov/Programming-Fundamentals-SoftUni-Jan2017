using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();

            var oddWords = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (i %2 !=0)
                {
                    oddWords.Add(words[i]);
                }
            }

            foreach (var word in oddWords)
            {
                Console.Write(word);
            }
            Console.WriteLine();
        }
    }
}
