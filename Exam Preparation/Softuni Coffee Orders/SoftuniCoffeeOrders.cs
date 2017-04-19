using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Softuni_Coffee_Orders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var orders = new List<decimal>();

            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = Console.ReadLine().Split('/');
                var capsulesCount = long.Parse(Console.ReadLine());

                var yearOfOrder = int.Parse(orderDate[2]);
                var monthOfOrder = int.Parse(orderDate[1]);

                var days = DateTime.DaysInMonth(yearOfOrder, monthOfOrder);

                var price = (days * capsulesCount) * pricePerCapsule;

                orders.Add(price);

            }

            foreach (var order in orders)
            {
                Console.WriteLine($"The price for the coffee is: ${order:f2}");
            }
            Console.WriteLine($"Total: ${orders.Sum():f2}");
        }
    }
}
