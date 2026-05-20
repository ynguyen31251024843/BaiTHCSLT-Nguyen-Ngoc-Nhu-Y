using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises1
{
    internal class Bai01
    {
        static void Maina(string[] args)
        {
            Console.WriteLine("Add / Sum Two Numbers");
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Tong = " + sum);
        }
    }
}
