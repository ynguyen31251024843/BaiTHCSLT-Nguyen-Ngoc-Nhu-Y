using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises1
{
    internal class Bai08
    {
        static void Mainh(string[] args)
        {
            Console.WriteLine("Calculate Area of Circle");
            double r;
            Console.Write("Nhap ban kinh: ");
            r = double.Parse(Console.ReadLine());
            double dt = Math.PI * r * r;
            Console.WriteLine("Dien tich hinh tron la: " + dt);
        }
    }
}
