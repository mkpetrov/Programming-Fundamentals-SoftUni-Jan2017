using System;
using System.Linq;

namespace Randomize_Words
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                .Split(' ').ToArray();
            var rnd = new Random();

            for (int i = 0; i < inputLine.Length; i++)
            {
                int pos2 = rnd.Next(inputLine.Length);
                var tempWord = inputLine[pos2];
                inputLine[pos2] = inputLine[i];
                inputLine[i] = tempWord;
            }

            foreach (var word in inputLine)
            {
                Console.WriteLine(word);
            }
        }
    }
}
