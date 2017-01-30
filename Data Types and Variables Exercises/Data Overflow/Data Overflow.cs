using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = ulong.Parse(Console.ReadLine());
            decimal num2 = ulong.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (ushort.MinValue <= num1 && num1 <= ushort.MaxValue)
                {
                    Console.WriteLine("bigger type: ushort");
                }
                else if (uint.MinValue <= num1 && num1 <= uint.MaxValue)
                {
                    Console.WriteLine("bigger type: uint");
                }
                else if (num1 > uint.MaxValue)
                {
                    Console.WriteLine("bigger type: ulong");
                }
                if (byte.MinValue <= num2 && num2 <= byte.MaxValue)
                {
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine("{0} can overflow byte {1} times", num1, Math.Round(num1 / byte.MaxValue));
                }
                else if (ushort.MinValue <= num2 && num2 <= ushort.MaxValue)
                {
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine("{0} can overflow ushort {1} times", num1, Math.Round(num1 / ushort.MaxValue));
                }
                else if (uint.MinValue <= num2 && num2 <= uint.MaxValue)
                {
                    Console.WriteLine("smaller type: uint");
                    Console.WriteLine("{0} can overflow uint {1} times", num1, Math.Round(num1 / uint.MaxValue));
                }
                else if (num1 > uint.MaxValue)
                {
                    Console.WriteLine("smaller type: ulong");
                    Console.WriteLine("{0} can overflow ulong {1} times", num1, Math.Round(num1 / ulong.MaxValue));
                }
            }
            else
            {
                if (ushort.MinValue <= num2 && num2 <= ushort.MaxValue)
                {
                    Console.WriteLine("bigger type: ushort");
                }
                else if (uint.MinValue <= num2 && num2 <= uint.MaxValue)
                {
                    Console.WriteLine("bigger type: uint");
                }
                else if (num2 > uint.MaxValue)
                {
                    Console.WriteLine("bigger type: ulong");
                }
                if (byte.MinValue <= num1 && num1 <= byte.MaxValue)
                {
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine("{0} can overflow byte {1} times", num2, Math.Round(num2 / byte.MaxValue));
                }
                else if (ushort.MinValue <= num1 && num1 <= ushort.MaxValue)
                {
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine("{0} can overflow ushort {1} times", num2, Math.Round(num2 / ushort.MaxValue));
                }
                else if (uint.MinValue <= num1 && num1 <= uint.MaxValue)
                {
                    Console.WriteLine("smaller type: uint");
                    Console.WriteLine("{0} can overflow uint {1} times", num2, Math.Round(num2 / uint.MaxValue));
                }
                else if (num2 > uint.MaxValue)
                {
                    Console.WriteLine("smaller type: ulong");
                    Console.WriteLine("{0} can overflow ulong {1} times", num2, Math.Round(num1 / ulong.MaxValue));
                }
            }
        }
    }
}
