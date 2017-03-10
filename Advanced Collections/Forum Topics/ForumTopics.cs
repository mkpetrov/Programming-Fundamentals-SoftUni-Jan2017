using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_Topics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var storedTopics = new Dictionary<string, List<string>>();

            while (inputLine != "filter")
            {
                var entry = inputLine
                    .Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var topic = entry[0];

                if (!storedTopics.ContainsKey(topic))
                {
                    storedTopics[topic] = new List<string>();
                }
                for (int i = 1; i < entry.Count; i++)
                {
                    if (!storedTopics[topic].Contains(entry[i]))
                    {
                        storedTopics[topic].Add(entry[i]);
                    }
                    
                }

                inputLine = Console.ReadLine();
            }

            var neededTopics = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var topic in storedTopics)
            {
                var currentTopic = topic.Key;
                var currentTags = topic.Value;

                var containsAll = true;

                for (int i = 0; i < neededTopics.Count; i++)
                {
                    containsAll = true;
                    for (int j = 0; j < currentTags.Count; j++)
                    {
                        if (currentTags.Contains(neededTopics[i]))
                        {
                            containsAll = true;
                        }
                        else
                        {
                            containsAll = false;
                            break;
                        }
                    }
                    if (containsAll==false)
                    {
                        break;
                    }
                }
                if (containsAll==true)
                {
                    Console.WriteLine($"{currentTopic} | #{string.Join(", #",currentTags)}");
                }
            }
        }
    }
}
