using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises1
{
    internal class Bai10
    {
        static void Mainj(string[] args)
        {
            Console.WriteLine("Convert days to years, weeks and days");
            int d;
            Console.Write("Nhap so ngay: ");
            d = int.Parse(Console.ReadLine());
            int y = (d / 365);
            int w = (d % 365) / 7;
            int nd = (d % 365) % 7;
            Console.WriteLine($"{y} nam, {w} tuan, {nd} ngay");
        }
    }
}
