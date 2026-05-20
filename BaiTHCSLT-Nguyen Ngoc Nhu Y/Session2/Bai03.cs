using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai03
    {
        static void Main3(string[] args)
        {
            Console.WriteLine(" Divide Two Numbers ");
            float a, b;
            Console.Write("Nhap a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = float.Parse(Console.ReadLine());
            float thuong = a / b;
            Console.WriteLine("Ket qua la: " + thuong);
        }

    }
}
