using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_Base
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var ageInfo = new Dictionary<string, int>();
            var salaryInfo = new Dictionary<string, double>();
            var positionInfo = new Dictionary<string, string>();

            while (input != "filter base")
            {
                var currentInput= input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int ages;

                double salary;

                var ageNumber = Int32.TryParse(currentInput[2], out ages);
                var salaryNumber = double.TryParse(currentInput[2], out salary);

                if (ageNumber==true)
                {
                    ageInfo.Add(currentInput[0], ages);
                }
                else if (salaryNumber==true)
                {
                    salaryInfo.Add(currentInput[0], salary);
                }
                if (ageNumber == false && salaryNumber == false)
                {
                    positionInfo.Add(currentInput[0], currentInput[2]);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            switch (input)
            {
                case "Age":
                    foreach (var info in ageInfo)
                    {
                        Console.WriteLine($"Name: {info.Key}");
                        Console.WriteLine($"Age: {info.Value}");
                        Console.WriteLine("====================");
                    }
                    break;
                case "Salary":
                    foreach (var info in salaryInfo)
                    {
                        Console.WriteLine($"Name: {info.Key}");
                        Console.WriteLine($"Salary: {info.Value:f2}");
                        Console.WriteLine("====================");
                    }
                    break;
                case "Position":
                    foreach (var info in positionInfo)
                    {
                        Console.WriteLine($"Name: {info.Key}");
                        Console.WriteLine($"Position: {info.Value}");
                        Console.WriteLine("====================");
                    }
                    break;
            }
        }
    }
}
