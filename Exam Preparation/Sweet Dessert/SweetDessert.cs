using System;

namespace Sweet_Dessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            double guests = double.Parse(Console.ReadLine());
            var priceBananas = double.Parse(Console.ReadLine());
            var priceEggs = double.Parse(Console.ReadLine());
            var priceBerries = double.Parse(Console.ReadLine());

            var numberOfPortions = Math.Ceiling(guests / 6);

            var neededMoney = numberOfPortions * (2 * priceBananas) + numberOfPortions * (4 * priceEggs) + numberOfPortions * (0.2 * priceBerries);

            if (cash>=neededMoney)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.",neededMoney);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.",neededMoney-cash);
            }
        }
    }
}
