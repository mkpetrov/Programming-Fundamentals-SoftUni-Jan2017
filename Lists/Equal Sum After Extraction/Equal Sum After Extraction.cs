using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var numberList2= Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var sumList1 = 0;

            var sumList2 = 0;

            for (int i = 0; i < numberList1.Count; i++)
            {
                for (int j = 0; j < numberList2.Count; j++)
                {
                    if (numberList1[i]!=numberList2[j])
                    {
                        numberList2.Remove(numberList1[i]);
                    }
                }
            }
            foreach (var number in numberList1)
            {
                sumList1 += number;
            }
            foreach (var number in numberList2)
            {
                sumList2 += number;
            }
            if (sumList1==sumList2)
            {
                Console.WriteLine("Yes. Sum: {0}",sumList1);
            }
            else
            {
                Console.WriteLine("No. Diff: {0}",Math.Abs(sumList1-sumList2));
            }
        }
    }
}
