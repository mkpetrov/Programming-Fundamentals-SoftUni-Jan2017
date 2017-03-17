using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var outputData = new Dictionary<string, Dictionary<string, decimal>>();

            while (inputLine != "end")
            {
                var input = inputLine
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var bank = input[0];
                var account = input[1];
                var balance = decimal.Parse(input[2]);

                if (!outputData.ContainsKey(bank))
                {
                    outputData[bank] = new Dictionary<string, decimal>();

                }
                if (!outputData[bank].ContainsKey(account))
                {
                    outputData[bank][account] = 0;
                }
                outputData[bank][account] += balance;

                inputLine = Console.ReadLine();
            }

            outputData = outputData
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Max(y => y.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in outputData)
            {
                var bankName = entry.Key;
                var accountInfo = entry.Value;
                accountInfo = accountInfo.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);

                foreach (var name in accountInfo)
                {
                    Console.WriteLine("{0} -> {1} ({2})", name.Key, name.Value, bankName);
                }
            }
        }
    }
}