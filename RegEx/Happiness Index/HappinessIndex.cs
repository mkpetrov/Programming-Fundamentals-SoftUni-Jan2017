using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Happiness_Index
{
    class HappinessIndex
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var happyRegex = new Regex(@":\)|:D|;\)|:\*|:]|;]|:}|;}|\(:|\*:|c:|\[:|\[;");
            var sadRegex = new Regex(@":\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|]:|];");

            MatchCollection happyEmotes = happyRegex.Matches(inputLine);
            MatchCollection sadEmotes = sadRegex.Matches(inputLine);

            var happyCount = 0.0;
            var sadCount = 0.0;

            foreach (Match happy in happyEmotes)
            {
                happyCount++;
            }
            foreach (Match sad in sadEmotes)
            {
                sadCount++;
            }

            double happinesIndex = happyCount / sadCount;

            if (happinesIndex>=2)
            {
                Console.WriteLine("Happiness index: {0:f2} :D",happinesIndex);
            }
            else if (happinesIndex>1&&happinesIndex<2)
            {
                Console.WriteLine("Happiness index: {0:f2} :)",happinesIndex);
            }
            else if (happinesIndex==1)
            {
                Console.WriteLine("Happiness index: {0:f2} :|",happinesIndex);
            }
            else if (happinesIndex<1)
            {
                Console.WriteLine("Happiness index: {0:f2} :(",happinesIndex);
            }
            Console.WriteLine("[Happy count: {0}, Sad count: {1}]", happyCount, sadCount);
        }
    }
}
