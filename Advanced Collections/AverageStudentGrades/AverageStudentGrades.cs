using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var studentRecord = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var studentGrade = Console.ReadLine().Split(' ');
                var student = studentGrade[0];
                var grade = double.Parse(studentGrade[1]);

                if (!studentRecord.ContainsKey(student))
                {
                    studentRecord[student] = new List<double>();
                }
                studentRecord[student].Add(grade);
            }

            foreach (var student in studentRecord)
            {
                var name = student.Key;
                var studenGrade = student.Value;

                var averageGrades = studenGrade.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studenGrade)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {averageGrades:f2})");
            }
            
        }
    }
}
