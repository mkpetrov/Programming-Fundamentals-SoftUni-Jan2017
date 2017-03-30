using System;
using System.Linq;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reversedInput = new string(input.Reverse().ToArray());

            Console.WriteLine(reversedInput);
        }
    }
}
