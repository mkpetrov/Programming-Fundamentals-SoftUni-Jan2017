using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            int coutnLetters = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length==1)
                {
                    coutnLetters++;
                }
            }
            Console.WriteLine(coutnLetters);
        }
    }
}
