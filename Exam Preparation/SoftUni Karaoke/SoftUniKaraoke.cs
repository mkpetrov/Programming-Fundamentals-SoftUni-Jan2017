using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine().Split(',');

            var realSongs = new List<string>();

            foreach (var song in songs)
            {
                realSongs.Add(song.Trim());
            }

            var output = new Dictionary<string, SortedSet<string>>();
                

            var inputLine = Console.ReadLine();

            while (inputLine !="dawn")
            {
                var input = inputLine.Split(',');
                var name = input[0];
                var song = input[1].Trim();
                var award = input[2].Trim();

                if (names.Contains(name) && realSongs.Contains(song))
                {
                    if (!output.ContainsKey(name))
                    {
                        output[name] = new SortedSet<string>();
                    }
                    output[name].Add(award);
                }

                inputLine = Console.ReadLine();
            }

            output = output
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x=>x.Key,x=>x.Value);

            if (output.Count>0)
            {
                foreach (var kvp in output)
                {
                    Console.WriteLine("{0}: {1} awards", kvp.Key, kvp.Value.Count);
                    foreach (var entry in kvp.Value)
                    {
                        Console.WriteLine("--{0}", entry);
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }

            
        }
    }
}
