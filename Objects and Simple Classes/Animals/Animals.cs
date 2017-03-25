using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumbersOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }
    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }
    public class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    class Animals
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            Dictionary<string, Dog> dogs = new Dictionary<string, Dog>();
            Dictionary<string, Cat> cats = new Dictionary<string, Cat>();
            Dictionary<string, Snake> snakes = new Dictionary<string, Snake>();

            while (inputLine != "I'm your Huckleberry")
            {
                var input = inputLine.Split(' ').ToArray();

                if (input.Length>2)
                {
                    switch (input[0])
                    {
                        case "Dog":
                            var name = input[1];
                            var age = input[2];
                            var numberOfLegs = input[3];

                            var newDog = new Dog();
                            newDog.Name = name;
                            newDog.Age = int.Parse(age);
                            newDog.NumbersOfLegs = int.Parse(numberOfLegs);

                            dogs[name] = newDog;

                            break;
                        case "Cat":
                            var catName = input[1];
                            var catAge = input[2];
                            var catIntelligenceQuotient = input[3];

                            var newCat = new Cat();
                            newCat.Name = catName;
                            newCat.Age = int.Parse(catAge);
                            newCat.IntelligenceQuotient = int.Parse(catIntelligenceQuotient);

                            cats[catName] = newCat;
                            break;
                        case "Snake":
                            var snakeName = input[1];
                            var snakeAge = input[2];
                            var snakeCrueltyCoefficient = input[3];

                            var newSnake = new Snake();
                            newSnake.Name = snakeName;
                            newSnake.Age = int.Parse(snakeAge);
                            newSnake.CrueltyCoefficient = int.Parse(snakeCrueltyCoefficient);

                            snakes[snakeName] = newSnake;
                            break;
                    }
                }
                else
                {
                    var inputTalk = inputLine.Split(' ');

                    if (dogs.ContainsKey(inputTalk[1]))
                    {
                        dogs[inputTalk[1]].ProduceSound();
                    }
                    else if (cats.ContainsKey(inputTalk[1]))
                    {
                        cats[inputTalk[1]].ProduceSound();
                    }
                    else if (snakes.ContainsKey(inputTalk[1]))
                    {
                        snakes[inputTalk[1]].ProduceSound();
                    }
                    
                }

                inputLine = Console.ReadLine();
            }
            foreach (var dog in dogs)
            {
                Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}",dog.Key,dog.Value.Age,dog.Value.NumbersOfLegs);
            }
            foreach (var cat in cats)
            {
                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}",cat.Key,cat.Value.Age,cat.Value.IntelligenceQuotient);
            }
            foreach (var snake in snakes)
            {
                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}",snake.Key,snake.Value.Age,snake.Value.CrueltyCoefficient);
            }
        }
    }
}
