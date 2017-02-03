using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string text = RepeatString(str, count);
            Console.WriteLine(text);
        }
        static string RepeatString(string str,int count)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }
            return repeatedString;
            
        }
    }
}
