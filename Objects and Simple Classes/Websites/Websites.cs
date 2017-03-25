using System;
using System.Collections.Generic;
using System.Linq;

namespace Websites
{
    public class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public new List<string> Queries { get; set; }
    }
    class Websites
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var websaits = new List<Website>();

            while (inputLine !="end")
            {
                var input = inputLine.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var host = input[0];
                var domain = input[1];
                List<string> queries = input.Skip(2).ToList();

                var newWebsite = new Website();
                newWebsite.Host = host;
                newWebsite.Domain = domain;
                newWebsite.Queries = queries;

                websaits.Add(newWebsite);

                inputLine = Console.ReadLine();
            }

            foreach (var websait in websaits)
            {
                if (websait.Queries.Count==0)
                {
                    Console.WriteLine("https://www.{0}.{1}",websait.Host,websait.Domain);
                }
                else
                {
                    Console.WriteLine("https://www.{0}.{1}/query?=[{2}]",websait.Host,websait.Domain,string.Join("]&[",websait.Queries));
                }
            }
        }
    }
}
