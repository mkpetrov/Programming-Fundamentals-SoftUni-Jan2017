using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToRotate = Console.ReadLine().Split(' ');

            var result = new string[wordsToRotate.Length];
            result[0] = wordsToRotate[wordsToRotate.Length - 1];

            for (int i = 0; i < wordsToRotate.Length-1; i++)
            {
                result[i + 1] = wordsToRotate[i];
            }

            var resAsString = string.Join(" ", result);
            Console.WriteLine(resAsString);
        }
    }
}
