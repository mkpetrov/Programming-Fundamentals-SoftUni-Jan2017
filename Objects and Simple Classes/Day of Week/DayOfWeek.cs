using System;
using System.Globalization;

namespace Day_of_Week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();

            var convertDate = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(convertDate.DayOfWeek);
        }
    }
}
