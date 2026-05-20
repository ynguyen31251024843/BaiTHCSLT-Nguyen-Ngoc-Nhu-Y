using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises1
{
    internal class Bai04
    {
        static void Maind(string[] args)
        {
            Console.WriteLine("convert feet to meter");
            double feet;
            Console.Write("Nhap so feet: ");
            feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"Met = {meter}");
        }
    }
}
