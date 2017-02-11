using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var commands = Console.ReadLine().Split(' ').ToArray();

        int start;

        var res = Int32.TryParse(commands[0], out start);

        Console.WriteLine(start);
    }
}