using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var wordsToCheck = new string[words.Length];

            int j = 0;

            bool check = true;

            for (int i = words.Length-1; i >= 0; i--)
            {
                wordsToCheck[j] = words[i];
                j++;
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i]==wordsToCheck[i])
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }

            if (check==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
