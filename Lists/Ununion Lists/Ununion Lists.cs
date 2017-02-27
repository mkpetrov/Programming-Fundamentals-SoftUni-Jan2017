using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var currentSequence= Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                
               for (int k = 0; k < currentSequence.Count; k++)
               {
                 if (primalList.Contains(currentSequence[k]))
                 {
                    primalList.RemoveAll(item=> item==currentSequence[k]);
                 }
                 else
                 {
                    primalList.Add(currentSequence[k]);
                 }
               }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
