using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingTime = Console.ReadLine();
            int numberOfSteps = int.Parse(Console.ReadLine())%86400;
            int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;

            var sumTime = numberOfSteps * secondsPerStep;

            DateTime dt = DateTime.ParseExact(startingTime, "HH:mm:ss", null);

            string result = dt.AddSeconds(sumTime).ToString("HH:mm:ss");

            Console.WriteLine("Time Arrival: {0}",result);
            
        }
    }
}
