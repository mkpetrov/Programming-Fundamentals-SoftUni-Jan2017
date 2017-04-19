using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in inputLine)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var firstPart = string.Empty;
                    var secondPart = string.Empty;

                    for (int i = 0; i < ticket.Length; i++)
                    {
                        if (i < 10)
                        {
                            firstPart += ticket[i];
                        }
                        else
                        {
                            secondPart += ticket[i];
                        }
                    }

                    var winningRegex = new Regex(@"(\${6,10}|@{6,10}|#{6,10}|\^{6,10})");

                    var winningLine = winningRegex.Match(firstPart);
                    var winningLine2 = winningRegex.Match(secondPart);

                    var matchCheck = winningRegex.IsMatch(firstPart);
                    var secondMatch = winningRegex.IsMatch(secondPart);

                    if (!matchCheck || !secondMatch)
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    }
                    else
                    {
                        var shorterMatch = Math.Min(winningLine.Length, winningLine2.Length);
                        
                        if (shorterMatch == 10)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2} Jackpot!", ticket, winningLine.Length, winningLine.Value[0]);
                        }
                        else
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", ticket, winningLine.Length, winningLine.Value[0]);
                        }
                    }
                }
            }
        }
    }
}
