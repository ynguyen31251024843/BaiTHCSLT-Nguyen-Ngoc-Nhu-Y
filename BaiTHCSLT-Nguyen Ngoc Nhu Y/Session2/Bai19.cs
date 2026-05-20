using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai19
    {
        static void Main19(string[] args)
        {
            Console.WriteLine("Check Integer in Range -10 to 10");
            int a, b;
            Console.Write("Enter first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = int.Parse(Console.ReadLine());
            bool kq = ((a >= -10) && (a <= 10)) || ((b >= -10) && (b <= 10));
            Console.WriteLine($"Result: {kq}");
        }
    }
}
