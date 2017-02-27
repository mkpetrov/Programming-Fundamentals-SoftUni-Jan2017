using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Array_of_Strings
{
    class SortArrayOfStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i].CompareTo(input[i + 1]) == 1)
                    {
                        var temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }

                }
            } while (swapped);
            
            Console.WriteLine(string.Join(" ",input));
            
        }
    }
}
