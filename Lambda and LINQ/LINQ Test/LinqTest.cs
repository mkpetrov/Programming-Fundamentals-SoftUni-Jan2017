using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test
{
    class LinqTest
    {
        static void Main(string[] args)
        {
            var testList = new List<string>();

            var namesToAdd = Console.ReadLine().Split(' ').ToArray();

            foreach (var name in namesToAdd)
            {
                testList.Add(name.Reverse().);
            }
        }
    }
}
