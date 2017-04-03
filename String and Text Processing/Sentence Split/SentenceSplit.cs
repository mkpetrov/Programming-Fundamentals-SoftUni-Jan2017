using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_Split
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var delimiter = Console.ReadLine();

            Console.Write("[");
            Console.Write(string.Join(", ",inputLine.Split(new[] { delimiter},StringSplitOptions.None)));
            Console.WriteLine("]");
        }
    }
}
