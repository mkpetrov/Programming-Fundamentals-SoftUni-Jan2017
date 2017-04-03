using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Stringify
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public new List<int> Grades { get; set; }
    }

    class JSONStringify
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (inputLine != "stringify")
            {
                var input = inputLine
                    .Split(new[] { ' ', ':', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var name = input[0];
                var age = int.Parse(input[1]);
                List<int> grades = input.Skip(2).Select(x => int.Parse(x)).ToList();

                var newStudent = new Student();

                newStudent.Name = name;
                newStudent.Age = age;
                newStudent.Grades = grades;

                students.Add(newStudent);

                inputLine = Console.ReadLine();
            }

            string output = "";
            output += "[";
            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];

                output += "{";
                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades) + "]";
                output += "}";

                if (i<students.Count-1)
                {
                    output += ",";
                }
            }
            output += "]";

            Console.WriteLine(output);
        }
    }
}
