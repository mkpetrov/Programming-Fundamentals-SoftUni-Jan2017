using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var position = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var addingCoords = Console.ReadLine().Split(' ').ToArray();

            var X = 0;
            var Y = 0;

            for (int i = 0; i < addingCoords.Length; i++)
            {
                if (addingCoords[i]=="up")
                {
                    int value;
                    var findVlaue = Int32.TryParse(addingCoords[i + 1], out value);
                    Y += value;
                }
                else if (addingCoords[i]=="down")
                {
                    int value;
                    var findVlaue = Int32.TryParse(addingCoords[i + 1], out value);
                    Y -= value;
                }
                else if (addingCoords[i] == "left")
                {
                    int value;
                    var findVlaue = Int32.TryParse(addingCoords[i + 1], out value);
                    X -= value;
                }
                else if (addingCoords[i] == "right")
                {
                    int value;
                    var findVlaue = Int32.TryParse(addingCoords[i + 1], out value);
                    X += value;
                }
                
            }

            Console.WriteLine($"firing at [{X}, {Y}]");

            if (position[0]==X && position[1]==Y)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
