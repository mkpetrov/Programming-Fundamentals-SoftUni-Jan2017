using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var firstHalf = new List<int>();

            var secondHalf = new List<int>();

            var digitList = new List<int>();
            SplitingNumbers(numbers, firstHalf, secondHalf);
            secondHalf.Reverse();
            for (int i = 0; i < firstHalf.Count; i++)
            {
                digitList.Add(secondHalf[i] / 10);
                digitList.Add(firstHalf[i]);
                digitList.Add(secondHalf[i] % 10);
            }
            Console.WriteLine(string.Join(" ",digitList));
           
        }

        private static void SplitingNumbers(List<int> numbers, List<int> firstHalf, List<int> secondHalf)
        {
            for (int i = numbers.Count - 1; i >= numbers.Count / 2; i--)
            {
                secondHalf.Add(numbers[i]);
            }
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                firstHalf.Add(numbers[i]);
            }
        }
    }
}
