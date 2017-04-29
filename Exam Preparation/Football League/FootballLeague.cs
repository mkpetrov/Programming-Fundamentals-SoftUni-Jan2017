using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            var patternInput = Regex.Escape(Console.ReadLine());
            var input = Console.ReadLine();
            var Teams = new Dictionary<string, long>();
            var TeamGoals = new Dictionary<string, long>();
            while (input != "final")
            {
                var actualTeampattern = patternInput + "([0-9a-zA-Z]*)" + patternInput + ".*" + patternInput + "([0-9a-zA-Z]*)" + patternInput;
                MatchCollection teamMatches = Regex.Matches(input, actualTeampattern);
                MatchCollection teamScores = Regex.Matches(input, @"(\d+):(\d+)$");
                foreach (Match match in teamScores)
                {
                    var score1 = int.Parse(match.Groups[1].Value);
                    var score2 = int.Parse(match.Groups[2].Value);
                    var team1 = teamMatches[0].Groups[1].Value;
                    var team2 = teamMatches[0].Groups[2].Value;
                    team2 = Reverse(team2).ToUpper();
                    team1 = Reverse(team1).ToUpper();
                    if (!Teams.ContainsKey(team1))
                    {
                        Teams[team1] = 0;
                    }
                    if (!TeamGoals.ContainsKey((team1)))
                    {
                        TeamGoals[team1] = 0;
                    }
                    if (!TeamGoals.ContainsKey((team2)))
                    {
                        TeamGoals[team2] = 0;
                    }
                    if (!Teams.ContainsKey(team2))
                    {
                        Teams[team2] = 0;
                    }
                    if (score1 == score2)
                    {
                        Teams[team1] += 1;
                        Teams[team2] += 1;

                    }
                    else if (score1 > score2)
                    {
                        Teams[team1] += 3;
                    }
                    else
                    {
                        Teams[team2] += 3;
                    }
                    TeamGoals[team1] += score1;
                    TeamGoals[team2] += score2;
                }
                input = Console.ReadLine();
            }
            var counter = 1;
            Console.WriteLine("League standings:");
            foreach (var keypair in Teams.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {

                Console.WriteLine(counter + ". " + keypair.Key + " " + keypair.Value);
                counter += 1;
            }
            Console.WriteLine("Top 3 scored goals:");

            foreach (var keypair in TeamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine("- " + keypair.Key + " -> " + keypair.Value);

            }

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}