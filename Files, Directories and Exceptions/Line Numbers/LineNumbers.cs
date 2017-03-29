using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Line_Numbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");

            var count = 1;

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt",$"{count}. "+ text[i] + Environment.NewLine);
                count++;
            }
        }
    }
}
