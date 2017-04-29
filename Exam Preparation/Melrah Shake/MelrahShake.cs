using System;

namespace Melrah_Shake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var pattern = Console.ReadLine();

            var firstIndex = inputString.IndexOf(pattern);
            var lastIndex = inputString.LastIndexOf(pattern);

            while (true)
            {
                if ((firstIndex >= 0 && lastIndex > 0) && pattern.Length>0)
                {
                    inputString  = inputString.Remove(lastIndex, pattern.Length);

                    inputString = inputString.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                var indexOfCharToRemove = pattern.Length / 2;

                pattern = pattern.Remove(indexOfCharToRemove, 1);

                firstIndex = inputString.IndexOf(pattern);
                lastIndex = inputString.LastIndexOf(pattern);
            }

            Console.WriteLine(inputString);
        }
    }
}
