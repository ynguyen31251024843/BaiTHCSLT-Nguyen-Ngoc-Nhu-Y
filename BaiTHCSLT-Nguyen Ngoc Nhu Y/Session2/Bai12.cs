using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai12
    {
        static void Main12(string[] args)
        {
            Console.WriteLine("Check Positive and Negative Pair");
            int a, b;
            Console.Write("Input first integer: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            b = int.Parse(Console.ReadLine());
            bool kq = (a < 0 && b > 0 || a > 0 && b < 0);
            Console.WriteLine($"Check if one is negative and one is positive: {kq}");
            
        }
    }
}
