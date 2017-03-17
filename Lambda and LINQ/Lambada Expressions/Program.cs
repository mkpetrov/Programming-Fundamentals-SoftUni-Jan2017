using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var lambadaExpression = new Dictionary<string, Dictionary<string, string>>();

            while (inputLine !="lambada")
            {
                if (inputLine !="dance")
                {
                    var input = inputLine
                        .Split(new[] { ' ', '=', '>','.' }, StringSplitOptions.RemoveEmptyEntries);

                    var selector = input[0];
                    var selectorObject = input[1];
                    var property = input[2];
                    if (!lambadaExpression.ContainsKey(selector))
                    {
                        lambadaExpression[selector] = new Dictionary<string, string>();
                    }
                    lambadaExpression[selector][selectorObject] = property;
                }
                else
                {
                    lambadaExpression = lambadaExpression
                        .ToDictionary(selector => selector.Key, selector => selector
                         .Value
                         .ToDictionary(selectorObject => selectorObject.Key, selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }

                inputLine = Console.ReadLine();
            }
            foreach (var selector in lambadaExpression)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine("{0} => {1}.{2}",selector.Key,selectorObject.Key,selectorObject.Value);
                }
            }
        }
    }
}
