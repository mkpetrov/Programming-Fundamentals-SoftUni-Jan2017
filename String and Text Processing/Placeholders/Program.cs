using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();

            while (inputText!="end")
            {
                var inputParts = inputText.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var input = inputParts[1].Split(new[] {',',' ' },StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i++)
                {
                    inputParts[0] = inputParts[0].Replace("{"+$"{i}"+"}",input[i]);
                }
                Console.WriteLine(inputParts[0]);

                inputText = Console.ReadLine();
            }
        }
    }
}
