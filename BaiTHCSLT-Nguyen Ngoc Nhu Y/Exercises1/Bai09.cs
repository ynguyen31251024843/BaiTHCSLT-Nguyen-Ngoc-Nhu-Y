using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises1
{
    internal class Bai09
    {
        static void Maini(string[] args)
        {
            Console.WriteLine("Calculate Area of Square");
            double a;
            Console.Write("Nhap canh: ");
            a = double.Parse(Console.ReadLine());
            double S = a * a;
            Console.WriteLine("Dien tich hinh vuong la: " + S);
        }
    }
}
