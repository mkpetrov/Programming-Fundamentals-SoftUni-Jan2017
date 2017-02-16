using System;
using System.Linq;

namespace _1._3.Phonebook
{
    class Program
    {
        static void Main()
        {
            var phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            var names = Console.ReadLine().Split(' ').ToArray();

            var name = Console.ReadLine();

            while (name !="done")
            {
                PrintElements(phoneNumbers, names, name);

                name = Console.ReadLine();
            }
        }

        static void PrintElements(string[] phoneNumbers, string[] names, string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i]==name)
                {
                    Console.WriteLine("{0} -> {1}",names[i],phoneNumbers[i]);
                }
            }
        }
    }
}