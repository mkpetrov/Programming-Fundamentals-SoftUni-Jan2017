using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int leftOperand = int.Parse(Console.ReadLine());
            char Operator = char.Parse(Console.ReadLine());
            int rightOperand = int.Parse(Console.ReadLine());
            switch (Operator)
            {
                case '+':
                    Console.WriteLine("{0} {1} {2} = {3}",leftOperand,Operator,rightOperand,leftOperand+rightOperand);
                    break;
                case '-':
                    Console.WriteLine("{0} {1} {2} = {3}", leftOperand, Operator, rightOperand, leftOperand - rightOperand);
                    break;
                case '*':
                    Console.WriteLine("{0} {1} {2} = {3}", leftOperand, Operator, rightOperand, leftOperand * rightOperand);
                    break;
                case '/':
                    Console.WriteLine("{0} {1} {2} = {3}", leftOperand, Operator, rightOperand, leftOperand / rightOperand);
                    break;
            }
        }
    }
}
