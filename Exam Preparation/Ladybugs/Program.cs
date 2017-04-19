using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var ladyBugsIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var field = new int[size];

            foreach (var ladyBugIndex in ladyBugsIndexes)
            {
                if (ladyBugIndex<0 || ladyBugIndex>=size)
                {
                    continue;
                }
                field[ladyBugIndex] = 1;
            }
            while (true)
            {
                var command = Console.ReadLine();

                if (command=="end")
                {
                    break;
                }

                var commandParts = command.Split(' ');

                var currentLadyBugIndex = int.Parse(commandParts[0]);
                var direction = commandParts[1];
                var flyLenght = int.Parse(commandParts[2]);

                if (currentLadyBugIndex<0 ||currentLadyBugIndex>=size)
                {
                    continue;
                }

                if (field[currentLadyBugIndex]==0)
                {
                    continue;
                }

                field[currentLadyBugIndex] = 0;

                var position = currentLadyBugIndex;

                while (true)
                {
                    

                    if (direction=="right")
                    {
                        position += flyLenght;
                    }
                    else
                    {
                        position -= flyLenght;
                    }
                    if (position < 0 || position >= size)
                    {
                        break;
                    }

                    if (field[position]==1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",field));
        }
    }
}
