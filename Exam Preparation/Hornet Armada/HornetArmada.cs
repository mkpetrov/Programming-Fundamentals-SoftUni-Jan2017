using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Armada
{
    class HornetArmada
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var legionsWithActivity = new Dictionary<string, int>();
            var legionsWithSoldiers = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = int.Parse(inputLine[0]);
                var legionName = inputLine[1];
                var soldierType = inputLine[2];
                var soldierCount = int.Parse(inputLine[3]);

                if (!legionsWithSoldiers.ContainsKey(legionName))
                {
                    legionsWithSoldiers[legionName] = new Dictionary<string, int>();
                }
                if (!legionsWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionsWithSoldiers[legionName][soldierType] = 0;
                }
                legionsWithSoldiers[legionName][soldierType] += soldierCount;

                if (!legionsWithActivity.ContainsKey(legionName))
                {
                    legionsWithActivity[legionName] = 0;
                }
                if (legionsWithActivity[legionName] < lastActivity)
                {
                    legionsWithActivity[legionName] = lastActivity;
                }
            }

            // ORDERING OF A DICTANIRY BY THE NESTED DICT.'S VALUE !!!!!!!
            //    foreach (var legionEntry in legionsWithSoldiers
            //        .Where(legion => legion.Value.ContainsKey(soldierType))
            //        .OrderByDescending(legion => legion.Value[soldierType]))

            string[] queryParams = Console.ReadLine().Split('\\');


            if (queryParams.Length > 1)
            {

                int activity = int.Parse(queryParams[0]);

                string soldierType = queryParams[1];


                foreach (var legionEntry in legionsWithSoldiers
                    .Where(legion => legion.Value.ContainsKey(soldierType))
                    .OrderByDescending(legion => legion.Value[soldierType]))
                {

                    if (legionsWithActivity[legionEntry.Key] < activity)
                    {
                        Console.WriteLine("{0} -> {1}", legionEntry.Key, legionsWithSoldiers[legionEntry.Key][soldierType]);
                    }
                }
            }
            else
            {

                string soldierType = queryParams[0];


                foreach (var legionEntry in legionsWithActivity.OrderByDescending(legion => legion.Value))
                {

                    if (legionsWithSoldiers[legionEntry.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine("{0} : {1}", legionEntry.Value, legionEntry.Key);
                    }
                }
            }
        }
    }
}
