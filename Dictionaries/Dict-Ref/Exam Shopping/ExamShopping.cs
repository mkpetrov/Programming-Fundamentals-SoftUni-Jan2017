using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Shopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var stock = Console.ReadLine();

            var quantities = new Dictionary<string, long>();

            while (stock !="shopping time")
            {
                var currentProduct = stock.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                long productQuantities;

                var delivery = long.TryParse(currentProduct[2], out productQuantities);

                if (!quantities.ContainsKey(currentProduct[1]))
                {
                    quantities[currentProduct[1]] = 0;
                }
                quantities[currentProduct[1]] += productQuantities;

                stock = Console.ReadLine();
            }

            stock = Console.ReadLine();

            while (stock != "exam time")
            {
                var currentProduct = stock.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                long clientQuantities;

                var buying= long.TryParse(currentProduct[2], out clientQuantities);

                if (!quantities.ContainsKey(currentProduct[1]))
                {
                    Console.WriteLine($"{currentProduct[1]} doesn't exist");
                }
                if (quantities.ContainsKey(currentProduct[1]) && quantities[currentProduct[1]]<=0)
                {
                    Console.WriteLine($"{currentProduct[1]} out of stock");
                }
                if (quantities.ContainsKey(currentProduct[1]) && quantities[currentProduct[1]] > 0)
                {
                    quantities[currentProduct[1]] -= clientQuantities;
                    if (quantities[currentProduct[1]]<0)
                    {
                        quantities[currentProduct[1]] = 0;
                    }
                }
                
                stock = Console.ReadLine();
            }

            foreach (var product in quantities)
            {
                if (product.Value>0)
                {
                    Console.WriteLine($"{product.Key} -> {product.Value}");
                }
            }
        }
    }
}
