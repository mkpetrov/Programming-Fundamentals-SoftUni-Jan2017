using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstHalf = new List<int>();
            var secondHalf = new List<int>();

            var leftedNumbers= new List<int>();

            var finalNumbers= new List<int>();

            if (numbers.Count %2 !=0)
            {
                for (int i = (numbers.Count / 2) - 1; i > 0; i--)
                {
                    firstHalf.Add(numbers[i]);

                }
                for (int i = numbers.Count - 2; i > numbers.Count / 2; i--)
                {
                   secondHalf.Add(numbers[i]);
                }

                leftedNumbers.Add(numbers[0]);
                leftedNumbers.Add(numbers[numbers.Count / 2]);
                leftedNumbers.Add(numbers[numbers.Count - 1]);
                secondHalf.Reverse();
                finalNumbers.Add(numbers[0]);
                foreach (var item in secondHalf)
                {
                    finalNumbers.Insert(1, item);
                }
                finalNumbers.Insert(finalNumbers.Count, leftedNumbers[1]);
                foreach (var item in firstHalf)
                {
                    finalNumbers.Insert(finalNumbers.Count, item);
                }
                finalNumbers.Insert(finalNumbers.Count, leftedNumbers[2]);
                Console.WriteLine(string.Join(" ",finalNumbers));
            }
            else
            {
                leftedNumbers.Add(numbers[0]);
                leftedNumbers.Add(numbers[numbers.Count-1]);
                numbers.RemoveAt(0);
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Reverse();
                numbers.Insert(0, leftedNumbers[0]);
                numbers.Insert(numbers.Count, leftedNumbers[1]);
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
