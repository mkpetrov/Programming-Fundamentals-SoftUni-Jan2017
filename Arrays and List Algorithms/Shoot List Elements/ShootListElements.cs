using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>();

            string inputLine = Console.ReadLine();

            var lastNumber = 0;

            while (inputLine!="stop")
            {
                if (inputLine=="bang")
                {
                    
                    if (input.Count==1)
                    {
                        lastNumber = input[0];
                    }

                    var sumNumbers = 0.0;

                    for (int i = 0; i < input.Count; i++)
                    {
                        sumNumbers += input[i];
                    }

                    double averageNumber = sumNumbers / input.Count;

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (averageNumber > input[i] || input.Count == 1)
                        {
                            Console.WriteLine("shot {0}",input[i]);
                            input.RemoveAt(i);
                            break;
                        }
                    }

                    for (int i = 0; i < input.Count; i++)
                    {
                        input[i]--;
                    }

                    if (input.Count<1)
                    {
                        Console.WriteLine("nobody left to shoot! last one was {0}",lastNumber);
                        break;
                    }

                    inputLine = Console.ReadLine();
                }
                else
                {
                    var number = int.Parse(inputLine);
                    input.Insert(0,number);
                    inputLine = Console.ReadLine();
                }
            }
            if (input.Count>0 && inputLine=="stop")
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", input));
            }
            if(input.Count == 0 && inputLine == "stop")
            {
                Console.WriteLine("you shot them all. last one standing was {0}",lastNumber);
            }
            
        }
    }
}
