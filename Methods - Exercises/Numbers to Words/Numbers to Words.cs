using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
            {
                int num  = int.Parse(Console.ReadLine());
                Console.WriteLine(Letterize(num));
            }
        }

        static string Letterize(int num)
        {
            string result = string.Empty;
            if (num>999)
            {
              return  result += "too large";
            }
            if (num<-999)
            {
               return  result += "too small";
            }
            if (num<100 && num>-100)
            {
                return string.Empty;
            }
            string Words = string.Empty;

            if (num<0)
            {
                Words += "minus ";
            }
            num = Math.Abs(num);

            int firstDigit = num / 100;
            int secondDigit = (num / 10) % 10;
            int thirdDigit = num % 10;
            
            switch (firstDigit)
            {
                case 1:Words += "one";
                    break;
                case 2:
                    Words += "two";
                    break;
                case 3:
                    Words += "three";
                    break;
                case 4:
                    Words += "four";
                    break;
                case 5:
                    Words += "five";
                    break;
                case 6:
                    Words += "six";
                    break;
                case 7:
                    Words += "seven";
                    break;
                case 8:
                    Words += "eight";
                    break;
                case 9:
                    Words += "nine";
                    break;
            }
            Words += "-hundred";

            switch (secondDigit)
            {
                case 1:
                    switch (thirdDigit)
                    {
                        case 1:Words += " and eleven";
                            break;
                        case 2:
                            Words += " and twelve";
                            break;
                        case 3:
                            Words += " and thirteen";
                            break;
                        case 4:
                            Words += " and fourteen";
                            break;
                        case 5:
                            Words += " and fifteen";
                            break;
                        case 6:
                            Words += " and sixteen";
                            break;
                        case 7:
                            Words += " and seventeen";
                            break;
                        case 8:
                            Words += " and eighteen";
                            break;
                        case 9:
                            Words += " and nineteen";
                            break;
                        case 0:
                            Words += " and ten";
                            break;
                    }
                    break;
                case 2:
                    Words += " and twenty";
                    break;
                case 3:
                    Words += " and thirty";
                    break;
                case 4:
                    Words += " and forty";
                    break;
                case 5:
                    Words += " and fifty";
                    break;
                case 6:
                    Words += " and sixty";
                    break;
                case 7:
                    Words += " and seventy";
                    break;
                case 8:
                    Words += " and eighty";
                    break;
                case 9:
                    Words += " and ninety";
                    break;
                case 0:
                    switch (thirdDigit)
                    {
                        case 1:
                            Words += " and one";
                            break;
                        case 2:
                            Words += " and two";
                            break;
                        case 3:
                            Words += " and three";
                            break;
                        case 4:
                            Words += " and four";
                            break;
                        case 5:
                            Words += " and five";
                            break;
                        case 6:
                            Words += " and six";
                            break;
                        case 7:
                            Words += " and seven";
                            break;
                        case 8:
                            Words += " and eight";
                            break;
                        case 9:
                            Words += " and nine";
                            break;
                    }
                    break;
            }
            if (thirdDigit !=0 && secondDigit>1)
            {
                switch (thirdDigit)
                {
                    case 1:
                        Words += " one";
                        break;
                    case 2:
                        Words += " two";
                        break;
                    case 3:
                        Words += " three";
                        break;
                    case 4:
                        Words += " four";
                        break;
                    case 5:
                        Words += " five";
                        break;
                    case 6:
                        Words += " six";
                        break;
                    case 7:
                        Words += " seven";
                        break;
                    case 8:
                        Words += " eight";
                        break;
                    case 9:
                        Words += " nine";
                        break;
                }
            }
            return Words;
            
        }
    }
}


