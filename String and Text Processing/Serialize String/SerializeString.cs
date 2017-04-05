using System;
using System.Collections.Generic;

namespace Serialize_String
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var output = new Dictionary<char, List<int>>();

            for (int i = 0; i < inputLine.Length; i++)
            {
                var currentChar = inputLine[i];

                if (!output.ContainsKey(currentChar))
                {
                    output[currentChar] = new List<int>();
                }

                output[currentChar].Add(i);
            }

            foreach (var kvp in output)
            {
                Console.WriteLine("{0}:{1}",kvp.Key,string.Join("/",kvp.Value));
            }
        }
    }
}
