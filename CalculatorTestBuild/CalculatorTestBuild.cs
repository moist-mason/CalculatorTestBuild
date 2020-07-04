// Calculator Test Build; Written by Mason
// Built using .NET Framework v4.7.2 and Visual Studio Community 2019
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTestBuild
{
    class CalculatorTestBuild
    {
        static double num1;
        static double num2;

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Next, enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Operator();

            Console.ReadLine();
        }

        static void Operator()
        {
            double equation;

            Console.Write("Finally, enter an operator: ");
            string userOp = Console.ReadLine();

            switch (userOp)
            {
                case "+":
                    equation = num1 + num2;
                    Console.WriteLine(equation);
                    break;
                case "-":
                    equation = num1 - num2;
                    Console.WriteLine(equation);
                    break;
                case "*":
                    equation = num1 * num2;
                    Console.WriteLine(equation);
                    break;
                case "/":
                    equation = num1 / num2;
                    Console.WriteLine(equation);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}