﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Words_Sorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w=>w.Length<5)
                .Select(w=>w.ToLower())
                .OrderBy(w => w)
                .Distinct();

            Console.WriteLine(string.Join(", ",text));
        }
    }
}
