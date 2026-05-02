using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises3
{
    internal class Bai01
    {
        static void Maina1(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, x, /): ");
            string op = Console.ReadLine();

            double result = 0;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                case "x":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
