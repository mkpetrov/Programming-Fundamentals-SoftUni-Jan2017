using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var commandLine = Console.ReadLine();

            while (commandLine!="end")
            {
                var commandLineParts = commandLine.Split(' ');

                var command = commandLineParts[0];

                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(commandLineParts[1]);
                        if (index<=inputLine.Count)
                        {
                            var firstHalf = inputLine.Take(index + 1);
                            var secondHalf = inputLine.Skip(index + 1);

                            inputLine = secondHalf.Concat(firstHalf).ToList();
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "max":
                        var typeOfNumber = commandLineParts[1];

                        bool isMatched = false;
                        if (typeOfNumber=="odd")
                        {
                            var maxOdd = int.MinValue;
                            var maxIndex = 0;
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                if (inputLine[i]%2!=0 && inputLine[i]>=maxOdd)
                                {
                                    maxOdd = inputLine[i];
                                    maxIndex = i;
                                    isMatched = true;
                                }
                            }
                            if (isMatched==true)
                            {
                                Console.WriteLine(maxIndex);
                            }
                            
                        }
                        if (typeOfNumber=="even")
                        {
                            var maxEven = int.MinValue;
                            var maxEvenIndex = 0;
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                if (inputLine[i]%2==0 && inputLine[i]>=maxEven)
                                {
                                    maxEven = inputLine[i];
                                    maxEvenIndex = i;
                                    isMatched = true;
                                }
                            }
                            if (isMatched==true)
                            {
                                Console.WriteLine(maxEvenIndex);
                            }
                        }
                        if (isMatched==false)
                        {
                            Console.WriteLine("No matches");
                        }
                        break;

                    case "min":
                        var typeOfNumberMin = commandLineParts[1];

                        bool isMatchedMin = false;
                        if (typeOfNumberMin == "odd")
                        {
                            var maxOdd = int.MaxValue;
                            var maxIndex = 0;
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                if (inputLine[i] % 2 != 0 && inputLine[i] <= maxOdd)
                                {
                                    maxOdd = inputLine[i];
                                    maxIndex = i;
                                    isMatchedMin = true;
                                }
                            }
                            if (isMatchedMin == true)
                            {
                                Console.WriteLine(maxIndex);
                            }

                        }
                        if (typeOfNumberMin == "even")
                        {
                            var maxEven = int.MaxValue;
                            var maxEvenIndex = 0;
                            for (int i = 0; i < inputLine.Count; i++)
                            {
                                if (inputLine[i] % 2 == 0 && inputLine[i] <= maxEven)
                                {
                                    maxEven = inputLine[i];
                                    maxEvenIndex = i;
                                    isMatchedMin = true;
                                }
                            }
                            if (isMatchedMin == true)
                            {
                                Console.WriteLine(maxEvenIndex);
                            }
                        }
                        if (isMatchedMin == false)
                        {
                            Console.WriteLine("No matches");
                        }
                        break;

                    case "first":
                        var count = int.Parse(commandLineParts[1]);
                        var typeOfNum = commandLineParts[2];
                        if (count<=inputLine.Count)
                        {
                            if (typeOfNum=="even")
                            {
                                var listOfNumbs = new List<int>();
                                var countOfNum = 0;
                                for (int i = 0; i < inputLine.Count; i++)
                                {
                                    if (inputLine[i] %2==0)
                                    {
                                        if (countOfNum< count)
                                        {
                                            listOfNumbs.Add(inputLine[i]);
                                            countOfNum++;
                                        }
                                    }
                                }
                                if (listOfNumbs.Count>0)
                                {
                                    Console.WriteLine($"[{string.Join(", ",listOfNumbs)}]");
                                }
                                else
                                {
                                    Console.WriteLine("[]");
                                }
                            }
                            if (typeOfNum=="odd")
                            {
                                var listOfNumbs = new List<int>();
                                var countOfNum = 0;
                                for (int i = 0; i < inputLine.Count; i++)
                                {
                                    if (inputLine[i] % 2 != 0)
                                    {
                                        if (countOfNum < count)
                                        {
                                            listOfNumbs.Add(inputLine[i]);
                                            countOfNum++;
                                        }
                                    }
                                }
                                if (listOfNumbs.Count > 0)
                                {
                                    Console.WriteLine($"[{string.Join(", ", listOfNumbs)}]");
                                }
                                else
                                {
                                    Console.WriteLine("[]");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;

                    case "last":
                        var countLast = int.Parse(commandLineParts[1]);
                        var typeOfNumLast = commandLineParts[2];
                        if (countLast <= inputLine.Count)
                        {
                            if (typeOfNumLast == "even")
                            {
                                var listOfEvens = new List<int>();
                                for (int i = 0; i < inputLine.Count; i++)
                                {
                                    if (inputLine[i] %2==0)
                                    {
                                        listOfEvens.Add(inputLine[i]);
                                    }
                                    
                                }
                                if (listOfEvens.Count > 0)
                                {
                                    Console.WriteLine($"[{string.Join(", ", listOfEvens.Skip(listOfEvens.Count - countLast))}]");
                                }
                                else
                                {
                                    Console.WriteLine("[]");
                                }
                            }
                            if (typeOfNumLast == "odd")
                            {
                                var listOfOdds = new List<int>();
                                for (int i = 0; i < inputLine.Count; i++)
                                {
                                    if (inputLine[i] % 2 != 0)
                                    {
                                        listOfOdds.Add(inputLine[i]);
                                    }
                                    
                                }
                                if (listOfOdds.Count > 0)
                                {
                                    Console.WriteLine($"[{string.Join(", ", listOfOdds.Skip(listOfOdds.Count - countLast))}]");
                                }
                                else
                                {
                                    Console.WriteLine("[]");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ",inputLine)}]");
        }
    }
}
