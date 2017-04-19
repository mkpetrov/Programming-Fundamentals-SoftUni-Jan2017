using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var output = new Dictionary<int, Dictionary<string, SortedSet<string>>>();

            while (true)
            {
                
                var inputLine = Console.ReadLine();

                if (inputLine== "Time for Code")
                {
                    break;
                }
                var inputParts = inputLine.Split(' ');

                var id = int.Parse(inputParts[0]);
                var eventName = inputParts[1];
                var participants = inputParts.Skip(2).ToArray();

                if (eventName[0]!='#')
                {
                    
                    continue;
                }
                

                if (!output.ContainsKey(id))
                {
                    output[id] = new Dictionary<string, SortedSet<string>>();

                    if (!output[id].ContainsKey(eventName))
                    {
                        output[id][eventName] = new SortedSet<string>();
                    }
                   
                }
                if (!output[id].ContainsKey(eventName))
                {

                    continue;
                }
                foreach (var participant in participants)
                {
                    output[id][eventName].Add(participant);
                }

            }

            output = output.OrderByDescending(x => x.Value.Max(y=>y.Value.Count)).ToDictionary(x => x.Key, x => x.Value);
            
            foreach (var kvp in output)
            {
                var eventName = kvp.Value;
                foreach (var name in eventName)
                {
                    var entry = "";
                    foreach (var letter in name.Key)
                    {
                        if (letter != '#')
                        {
                            entry += letter;
                        }
                    }
                    Console.WriteLine($"{entry} - {name.Value.Count}");
                    foreach (var person in name.Value)
                    {
                        Console.WriteLine(person);
                    }
                }
            }
        }
    }
}
