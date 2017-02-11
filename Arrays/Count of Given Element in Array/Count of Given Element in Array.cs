using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int N = int.Parse(Console.ReadLine());

            int countRepeat = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==N)
                {
                    countRepeat++;
                }
            }

            Console.WriteLine(countRepeat);
        }
    }
}
