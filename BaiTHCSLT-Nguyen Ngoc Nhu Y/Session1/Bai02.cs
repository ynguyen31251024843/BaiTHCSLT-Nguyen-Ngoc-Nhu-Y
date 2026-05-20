using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises1
{
    internal class Bai02
    {
        static void Mainb(string[] args)
        {
            Console.WriteLine("Swap Values of Two Variables");
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
