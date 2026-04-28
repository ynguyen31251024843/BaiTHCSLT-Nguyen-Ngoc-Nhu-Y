using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai02
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Sum of Two Numbers");
            int a, b;
            Console.Write("Nhap so dau tien: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("Tong hai so la: " + sum);
        }
    }
}
