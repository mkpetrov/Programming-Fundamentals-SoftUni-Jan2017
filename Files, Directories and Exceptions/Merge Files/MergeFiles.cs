using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Merge_Files
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] fileOne = File.ReadAllLines("FileOne.txt");
            string[] fileTwo = File.ReadAllLines("FileTwo.txt");

            List<int> numbers = new List<int>();

            foreach (var file in fileOne)
            {
                numbers.Add(int.Parse(file));
            }
            foreach (var file in fileTwo)
            {
                numbers.Add(int.Parse(file));
            }
            numbers = numbers.OrderBy(x => x).ToList();

            foreach (var number in numbers)
            {
                File.AppendAllText("output.txt", number + Environment.NewLine);
            }
        }
    }
}
