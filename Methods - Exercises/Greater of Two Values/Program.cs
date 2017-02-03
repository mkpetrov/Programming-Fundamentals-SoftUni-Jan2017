using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int maxNumber = getMax(num1, num2);
                Console.WriteLine(maxNumber);
            }
            else if (type=="char")
            {
                char cha1 = char.Parse(Console.ReadLine());
                char cha2 = char.Parse(Console.ReadLine());
                char max = getMax(cha1, cha2);
                Console.WriteLine(max);
            }
            else
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string max = getMax(str1, str2);
                Console.WriteLine(max);
            }
        }

        static int getMax(int num1, int num2)
        {
             return Math.Max(num1, num2);
        }
        static char getMax(char cha1,char cha2)
        {
            if (cha1>cha2)
            {
                return cha1;
            }
            else
            {
                return cha2;
            }
        }
        static string getMax(string str1,string str2)
        {
            if (str1.CompareTo(str2)>=0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
    }
}
