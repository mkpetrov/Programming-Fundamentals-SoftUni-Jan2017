using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities_by_Continent_and_Country
{
    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var continentsData = new Dictionary<string,Dictionary<string,List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var continent = input[0];
                var country = input[1];
                var town = input[2];

                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }

                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }

                continentsData[continent][country].Add(town);

                
            }

            foreach (var token in continentsData)
            {
                var continentName = token.Key;
                var countries = token.Value;

                Console.WriteLine($"{continentName}:");

                foreach (var item in countries)
                {
                    var countryName = item.Key;
                    var cities = item.Value;

                    Console.WriteLine($"  {countryName} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
