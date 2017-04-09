using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var pattern = new Regex("([1]?[0-9JKQA])([SHDC])");

            MatchCollection matchedCards = pattern.Matches(inputLine);

            var validCards = new List<string>();

            foreach (Match card in matchedCards)
            {
                int power = 0;

                if (int.TryParse(card.Groups[1].Value,out power))
                {
                    if (power<2 ||power>10)
                    {
                        continue;
                    }
                }
                validCards.Add(card.Value);
            }
            Console.WriteLine(string.Join(", ",validCards));
        }
    }
}
