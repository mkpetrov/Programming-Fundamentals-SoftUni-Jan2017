using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            var commands = Console.ReadLine().Split(' ').ToArray();

            int start;

            double startingValue = 0;

            var res = Int32.TryParse(commands[0], out start);
            startingValue += start;

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i]=="up")
                {
                    int value;
                    var findVlaue= Int32.TryParse(commands[i+1], out value);
                    startingValue += value;
                }
                else if (commands[i]=="down")
                {
                    int value;
                    var findVlaue = Int32.TryParse(commands[i + 1], out value);
                    startingValue -= value;
                }
                if (startingValue<=0)
                {
                    Console.WriteLine("crashed");
                    break;
                }
            }
            if (startingValue>0)
            {
                Console.WriteLine($"got through safely. current altitude: {startingValue}m");
            }
            
            
        }
    }
}
