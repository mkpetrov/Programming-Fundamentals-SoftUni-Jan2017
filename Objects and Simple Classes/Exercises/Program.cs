using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercises
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public new List<string> Problems { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            List<Exercises> exercises = new List<Exercises>();

            while (inputLine != "go go go")
            {
                var input = inputLine
                    .Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    

                string topic = input[0];
                string courseName = input[1];
                string judgeContestLink = input[2];
                List<string> problems = input.Skip(3).ToList();

                var newExercise = new Exercises();

                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = judgeContestLink;
                newExercise.Problems = problems;

                exercises.Add(newExercise);

                inputLine = Console.ReadLine();
            }
            foreach (var exercise in exercises)
            {
                Console.WriteLine("Exercises: {0}",exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.",exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}",exercise.JudgeContestLink);
                int count = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}",count,problem);
                    count++;
                }
            }
        }
    }
}
