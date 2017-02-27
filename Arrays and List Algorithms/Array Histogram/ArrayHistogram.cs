using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Histogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            var inputWords = Console.ReadLine().Split(' ').ToList();

            var countWords = new List<int>();

            var words = new List<string>();

            for (int i = 0; i < inputWords.Count; i++)
            {
                if (words.Contains(inputWords[i]))
                {
                    int wordIndex = words.IndexOf(inputWords[i]);
                    countWords[wordIndex]++;
                }
                else
                {
                    words.Add(inputWords[i]);
                    countWords.Add(1);
                }
            }
            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < countWords.Count-1; i++)
                {
                    if (countWords[i]<countWords[i+1])
                    {
                        int temp = countWords[i];
                        countWords[i] = countWords[i + 1];
                        countWords[i + 1] = temp;

                        string tempWord = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tempWord;
                        hasSwapped = true;
                    }
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                double curentPers = (countWords[i] * 100.0) / inputWords.Count;
                Console.WriteLine("{0} -> {1} times ({2:F2}%)",words[i],countWords[i],curentPers);
            }
        }
    }
}
