using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string result = Console.ReadLine();
                if (result=="success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    Console.WriteLine($"Successfully executed {operation}.");
                    Console.WriteLine("==============================");
                    Console.WriteLine($"Message: {message}.");
                }
                if (result=="error")
                {
                    
                    string reason = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Error: Failed to execute {reason}.");
                    Console.WriteLine($"==============================");
                    Console.WriteLine($"Error Code: {code}.");
                    if (code>0)
                    {
                        Console.WriteLine($"Reason: Invalid Client Data.");
                        
                    }
                    else
                    {
                        Console.WriteLine($"Reason: Internal System Failure.");
                    }
                }
            }
        }
        
    }
}
