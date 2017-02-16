using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();

            var names = Console.ReadLine().Split(' ').ToArray();

            var commandArr = Console.ReadLine().Split(' ').ToArray();


            while (commandArr[0]!="done")
            {
                if (commandArr[0] == "call")
                {
                    CallingCommand(numbers, names, commandArr);
                }
                if (commandArr[0] == "message")
                {
                    MessageCommand(numbers, names, commandArr);
                }
                commandArr = Console.ReadLine().Split(' ').ToArray();
            }
        }

        private static void MessageCommand(string[] numbers, string[] names, string[] commandArr)
        {
            MessageSendByName(numbers, names, commandArr);
            MessageSendByNumber(numbers, names, commandArr);
        }

        private static void MessageSendByNumber(string[] numbers, string[] names, string[] commandArr)
        {
            long sumDigits = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (commandArr[1] == numbers[i])
                {
                    Console.WriteLine("sending sms to {0}...", names[i]);
                    var digits = numbers[i].ToCharArray();
                    foreach (var digit in digits)
                    {
                        if (digit >= 48 && digit <= 57)
                        {
                            sumDigits += digit - '0';
                        }
                    }
                    if (sumDigits % 2 == 0)
                    {
                        Console.WriteLine("meet me there");
                    }
                    if (sumDigits % 2 != 0)
                    {
                        Console.WriteLine("busy");
                    }
                }
            }
        }

        private static void MessageSendByName(string[] numbers, string[] names, string[] commandArr)
        {
           
            long sumDigits = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (commandArr[1] == names[i])
                {
                    Console.WriteLine("sending sms to {0}...", numbers[i]);
                    var digits = numbers[i].ToCharArray();
                    foreach (var digit in digits)
                    {
                        if (digit >= 48 && digit <= 57)
                        {
                            sumDigits += digit - '0';
                        }
                    }
                    if (sumDigits % 2 == 0)
                    {
                        Console.WriteLine("meet me there");
                    }
                    if (sumDigits % 2 != 0)
                    {
                        Console.WriteLine("busy");
                    }
                }
            }
        }

        private static void CallingCommand(string[] numbers, string[] names, string[] commandArr)
        {
            CollingWithNumber(numbers, names, commandArr);
            CallingWithName(numbers, names, commandArr);
        }

        private static void CallingWithName(string[] numbers, string[] names, string[] commandArr)
        {
            long sumDigits = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (commandArr[1] == names[i])
                {
                    Console.WriteLine("calling {0}...", numbers[i]);
                    var digits = numbers[i].ToCharArray();
                    foreach (var digit in digits)
                    {
                        if (digit >= 48 && digit <= 57)
                        {
                            sumDigits += digit - '0';
                        }
                    }
                    if (sumDigits % 2 == 0)
                    {
                        Console.WriteLine("call ended. duration: {0:D2}:{1:D2}", sumDigits / 60, sumDigits % 60);
                    }
                    if (sumDigits % 2 != 0)
                    {
                        Console.WriteLine("no answer");
                    }
                }
            }
        }

        private static void CollingWithNumber(string[] numbers, string[] names, string[] commandArr)
        {
            
            long sumDigits = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (commandArr[1] == numbers[i])
                {
                    Console.WriteLine("calling {0}...", names[i]);
                    var digits = numbers[i].ToCharArray();
                    foreach (var digit in digits)
                    {
                        if (digit >= 48 && digit <= 57)
                        {
                            sumDigits += digit - '0';
                        }
                    }
                    if (sumDigits % 2 == 0)
                    {
                        Console.WriteLine("call ended. duration: {0:D2}:{1:D2}", sumDigits / 60, sumDigits % 60);
                    }
                    if (sumDigits % 2 != 0)
                    {
                        Console.WriteLine("no answer");
                    }
                }
            }
        }
    }
}
