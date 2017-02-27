using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var upperNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var lowerNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            
            var idealNumberOfDigits = CalculateIdealNumberOfDIgits(upperNumbers, lowerNumbers);

            for (int i = 0; i < upperNumbers.Count; i++)
            {
                var currentNumber = CalculateNumberOfDigits(upperNumbers[i]);
                if (currentNumber>idealNumberOfDigits)
                {
                    upperNumbers.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < lowerNumbers.Count; i++)
            {
                var currentNumber = CalculateNumberOfDigits(lowerNumbers[i]);
                if (currentNumber > idealNumberOfDigits)
                {
                    lowerNumbers.RemoveAt(i);
                    i--;
                }
            }

            var zipper = new List<int>();

            if (upperNumbers.Count == lowerNumbers.Count)
            {
                for (int i = 0; i < lowerNumbers.Count; i++)
                {
                    zipper.Add(lowerNumbers[i]);
                    zipper.Add(upperNumbers[i]);

                }
                Console.WriteLine(string.Join(" ", zipper));
            }
            if (upperNumbers.Count > lowerNumbers.Count)
            {
                for (int i = 0; i < upperNumbers.Count; i++)
                {
                    if (i < lowerNumbers.Count)
                    {
                        zipper.Add(lowerNumbers[i]);
                    }
                    zipper.Add(upperNumbers[i]);
                }
                Console.WriteLine(string.Join(" ", zipper));
            }
            if (lowerNumbers.Count > upperNumbers.Count)
            {
                for (int i = 0; i < lowerNumbers.Count; i++)
                {
                    zipper.Add(lowerNumbers[i]);
                    if (i < upperNumbers.Count)
                    {
                        zipper.Add(upperNumbers[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", zipper));
            }
        }

        private static int CalculateIdealNumberOfDIgits(List<int> upperNumbers, List<int> lowerNumbers)
        {
            var idealNumberOfDigits = int.MaxValue;
            foreach (var item in upperNumbers)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);
                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }
            foreach (var item in lowerNumbers)
            {
                var numberOfDigits = CalculateNumberOfDigits(item);
                if (numberOfDigits < idealNumberOfDigits)
                {
                    idealNumberOfDigits = numberOfDigits;
                }
            }

            return idealNumberOfDigits;
        }

        static int CalculateNumberOfDigits(int number )
        {
            number = Math.Abs(number);
            var numberOfDigits = 0;
            while (number>0)
            {
                numberOfDigits++;
                number =number/10;
            }
            return numberOfDigits;
        }
    }
}
