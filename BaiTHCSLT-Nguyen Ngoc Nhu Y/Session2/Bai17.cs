using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai17
    {
        static void Main17(string[] args)
        {
            Console.WriteLine("Check Multiple of 3 or 7");
            int a;
            Console.Write("Nhap mot so: ");
            a = int.Parse(Console.ReadLine());
            bool kq = ((a % 3 == 0) || (a % 7 == 0));
            Console.WriteLine($"Ket qua: {kq}");

        }
    }
}
