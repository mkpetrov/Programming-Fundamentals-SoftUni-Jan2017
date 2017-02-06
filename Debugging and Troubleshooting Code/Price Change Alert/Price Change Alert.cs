using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double border = double.Parse(Console.ReadLine());

        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());

            double difference = Rate(last, price);
            bool isSignificantDifference = FindingDifrence(difference, border);

            Console.WriteLine(Get(price, last, difference, isSignificantDifference));

            last = price;
        }
    }

    private static string Get(double price, double last, double difference, bool etherTrueOrFalse)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", price);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, difference);
        return to;
    }
    private static bool FindingDifrence(double border, double isDiff)
    {
        if (Math.Abs(border) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Rate(double last, double price)
    {
        double rate = (price - last) / last;
        return rate*100;
    }
}
