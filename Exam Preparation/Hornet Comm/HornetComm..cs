namespace _02.Hornet_Comm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var messages = new List<string>();
            var broadcasts = new List<string>();
            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine== "Hornet is Green")
                {
                    break;
                }

                var prvtMsgPattern = new Regex(@"^(\d+) \<\-\> (\d+|\w+)$");
                var broadcastPattern = new Regex(@"^(\D+) \<-\> (\d+|\w+)$");

                var privateMessage = prvtMsgPattern.Match(inputLine);
                var broadcast = broadcastPattern.Match(inputLine);

                if (privateMessage.Success)
                {
                    //Private Message
                    var recipientCode = string.Join("", privateMessage.Groups[1].Value.Reverse());
                    var prvtMessage = privateMessage.Groups[2].Value;

                    messages.Add(recipientCode + " -> " + prvtMessage);

                }
                else if (broadcast.Success)
                {
                    //Broadcast
                    var broadcastMessage = broadcast.Groups[1].Value;
                    var frequency = string.Empty;

                    foreach (var entry in broadcast.Groups[2].Value)
                    {
                        if (entry>=65 && entry<=90)
                        {
                            frequency += char.ToLower(entry);
                        }
                        else if (entry>=97 && entry<=122)
                        {
                            frequency += char.ToUpper(entry);
                        }
                        else
                        {
                            frequency += entry;
                        }
                    }

                    broadcasts.Add(frequency + " -> "+ broadcastMessage);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine(string.Join("\n", broadcast));
                }
            }
            
            Console.WriteLine("Messages:");
            if (messages.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(string.Join("\n", message));
                }
            }
            
        }
    }
}

