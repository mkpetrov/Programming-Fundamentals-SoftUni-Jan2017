using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Interpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string inputLine = Console.ReadLine();

            while (inputLine!="end")
            {
                string[] inputParams = inputLine.Split(' ');

                string command = inputParams[0];
                switch (command)
                {
                    case "reverse":
                        int reverseStart =int.Parse(inputParams[2]);
                        int reverseCount = int.Parse(inputParams[4]);

                        if (isValid(array,reverseStart,reverseCount))
                        {
                            Reverse(array, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        
                        break;
                    case "sort":
                        int sortStart = int.Parse(inputParams[2]);
                        int sortCount = int.Parse(inputParams[4]);

                        if (isValid(array,sortStart,sortCount))
                        {
                            Count(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollLeft":
                        int rollLeftCount = int.Parse(inputParams[1]);

                        if (rollLeftCount>=0)
                        {
                            rollLeft(array, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollRight":
                        int rollRightCount = int.Parse(inputParams[1]);

                        if (rollRightCount>=0)
                        {
                            rollRight(array, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ",array)}]");
        }

        private static bool isValid(List<string> array, int Start, int Count)
        {
            bool result = Start >= 0 && Start < array.Count && Count >= 0 && (Count+Start) <= array.Count;
            return result;
        }

        private static void rollRight(List<string> array, int rollRightCount)
        {
            int rotations = rollRightCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                string lastElement = array[array.Count - 1];

                for (int j = array.Count - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = lastElement;
            }
        }

        private static void rollLeft(List<string> array, int rollLeftCount)
        {
            int rotations = rollLeftCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                string firstElement = array[0];

                for (int j = 0; j < array.Count-1; j++)
                {
                    array[j] = array[j+1];
                }
                array[array.Count - 1] = firstElement;
            }
        }

        private static void Count(List<string> array, int sortStart, int sortCount)
        {
            array.Sort(sortStart, sortCount,null);
        }

        private static void Reverse(List<string> array, int reverseStart, int reverseCount)
        {
            array.Reverse(reverseStart, reverseCount);
        }
    }
}
