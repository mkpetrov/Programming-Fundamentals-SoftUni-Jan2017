using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var blacklistedWords = Console.ReadLine().Split(' ').ToList();

            var fileName = Console.ReadLine();

            var trackList = new List<string>();

            

            while (fileName != "end")
            {
                bool isThere = false;
                for (int i = 0; i < blacklistedWords.Count; i++)
                {
                    if (fileName.Contains(blacklistedWords[i]))
                    {
                        isThere = true;
                    }
                }

                if (isThere !=true)
                {
                    trackList.Add(fileName);
                }
                

                fileName = Console.ReadLine();

            }
            foreach (var track in trackList.OrderBy(x=>x))
            {
                Console.WriteLine(track);
            }
        }
    }
}
