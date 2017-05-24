using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyfer
{
    public class Spyfer
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < inputLine.Count; i++)
            {

                var currentNumber = inputLine[i];
                if (i==0 && currentNumber == inputLine[i + 1])
                {
                    inputLine.RemoveAt(i + 1);
                    i = 0;
                   
                }
                else if (i !=0 && i !=inputLine.Count-1 && currentNumber==inputLine[i-1]+inputLine[i+1])
                {
                    inputLine.RemoveAt(i + 1);
                    inputLine.RemoveAt(i-1);
                    i = 0;
                }
                else if (i==inputLine.Count-1 && inputLine[i-1]==currentNumber)
                {
                    inputLine.RemoveAt(i - 1);
                    i = 0;
                       
                }
                
                
            }

            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}