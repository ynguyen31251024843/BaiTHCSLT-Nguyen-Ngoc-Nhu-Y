using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises1
{
    internal class Bai03
    {
        static void Mainc(string[] args)
        {
            Console.WriteLine("Multiply two Floating Point Numbers");
            float a, b;
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            float result = a * b;
            Console.WriteLine("Tich = " + result);
        }
    }
}
