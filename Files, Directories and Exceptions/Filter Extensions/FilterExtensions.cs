using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filter_Extensions
{
    class FilterExtensions
    {
        static void Main(string[] args)
        {
            string[] filesNames = Directory.GetFiles("01. Filter-Extensions/input");

            var input = Console.ReadLine();

            var output = new List<string>();

            for (int i = 0; i < filesNames.Length; i++)
            {
                var fileParts = filesNames[i].Split('.');

                if (input==fileParts[fileParts.Length-1])
                {
                    output.Add(filesNames[i]);
                }
            }

            output = output.Select(x => x.Split('\\')[x.Split('\\').Length - 1]).ToList();


            Console.WriteLine(string.Join("\n\r",output));
        }
    }
}
