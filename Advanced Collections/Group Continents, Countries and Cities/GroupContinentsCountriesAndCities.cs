using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Continents__Countries_and_Cities
{
    class GroupContinentsCountriesAndCities
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0];
                var country = input[1];
                var town = input[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new SortedSet<string>();
                }

                data[continent][country].Add(town);
            }


            foreach (var token in data)
            {
                var continentName = token.Key;
                var countries = token.Value;
                Console.WriteLine($"{continentName}:");

                foreach (var countryName in countries)
                {
                    var currentCountry = countryName.Key;
                    var cities = countryName.Value;
                    Console.WriteLine($"  {currentCountry} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
