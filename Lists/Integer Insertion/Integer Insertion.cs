using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var inputList = new List<string>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                inputList.Add(input);
                input = Console.ReadLine();
            }
            CalculateFirstDigit(numbers, inputList);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void CalculateFirstDigit(List<int> numbers, List<string> inputList)
        {
            foreach (var number in inputList)
            {
                int intNumber = Int32.Parse(number);
                var firstNumber = 0;
                if (intNumber < 10)
                {
                    numbers.Insert(intNumber, intNumber);
                }
                else
                {
                    while (intNumber > 10)
                    {
                        intNumber /= 10;
                        firstNumber = intNumber;
                    }
                    intNumber = Int32.Parse(number);
                    numbers.Insert(firstNumber, intNumber);
                }
            }
        }
    }
}
