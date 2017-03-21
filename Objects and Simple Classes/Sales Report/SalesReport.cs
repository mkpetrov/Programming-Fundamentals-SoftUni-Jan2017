using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sale Parse(string saleAsString)
        {
            var saleParts = saleAsString
                .Split(' ');

            return new Sale
            {
                Town = saleParts[0],
                Product = saleParts[1],
                Price = decimal.Parse(saleParts[2]),
                Quantity = decimal.Parse(saleParts[3])
            };
        }
    }

    class SalesReport
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentSaleAsString = Console.ReadLine();
                var currnetSale = Sale.Parse(currentSaleAsString);

                if (!result.ContainsKey(currnetSale.Town))
                {
                    result[currnetSale.Town] = 0;
                }
                result[currnetSale.Town] += currnetSale.Quantity * currnetSale.Price;
            }
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
