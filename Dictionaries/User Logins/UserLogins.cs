using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Logins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var savedInformation = new Dictionary<string, string>();

            while (input != "login")
            {
                var user = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                savedInformation[user[0]] = user[2];

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var count = 0;

            while (input != "end")
            {
                var user = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!savedInformation.ContainsKey(user[0]) || !savedInformation.ContainsValue(user[2]))
                {
                    Console.WriteLine($"{user[0]}: login failed");
                    count++;
                }
                else
                {
                    Console.WriteLine($"{user[0]}: logged in successfully");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
