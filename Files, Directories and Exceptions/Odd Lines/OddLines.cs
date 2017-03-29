using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Odd_Lines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("input.txt");

            for (int i = 1; i < file.Length; i+=2)
            {
                File.AppendAllText("output.txt", file[i] + Environment.NewLine);
            }
        }
    }
}
