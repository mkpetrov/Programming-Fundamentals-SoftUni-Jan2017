using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            var result = string.Empty;
            for (int i = 0; i < N; i++)
            {
                char word = char.Parse(Console.ReadLine());
                
                var encrypted=(Encrypt(word));

                result += encrypted;
            }
            Console.WriteLine(result);
            
            
        }

        static string Encrypt(char word)
        {
            var asciiNumber = (int)word;
            string encryption = string.Empty;

            while (asciiNumber>=10)
            {
                asciiNumber /= 10;
            }
            encryption += asciiNumber;
            asciiNumber = word;
            encryption += asciiNumber % 10;

            
            

            var firstSymbol = asciiNumber;
            while (asciiNumber>=10)
            {
                firstSymbol = asciiNumber / 10;
                asciiNumber = asciiNumber / 10;
            }
            asciiNumber = word;
            char lastSymbol = (char)(asciiNumber - firstSymbol);
            var frstSymbol = (char)(asciiNumber + asciiNumber % 10);


            string Encrpt = $"{frstSymbol}{encryption}{lastSymbol}";
            return Encrpt;
        }
    }
}
