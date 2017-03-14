using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register_Users
{
    class RegisterUsers
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var usernameDates = new Dictionary<string, DateTime>();

            while (inputLine != "end")
            {
                var token = inputLine
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    
                var username = token[0];
                var date = DateTime.ParseExact(token[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                usernameDates[username] = date;

                inputLine = Console.ReadLine();
            }

            var lastFiveUsers = usernameDates
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x=>x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var user in lastFiveUsers)
            {
                Console.WriteLine("{0}",user.Key);
            }
        }
    }
}
