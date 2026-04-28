using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai04
    {
        static void Main4(string[] args)
        {
            Console.WriteLine(" Swap Two Numbers");
            int a, b;
            Console.Write("Nhap so dau tien: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Sau khi doi: ");
            Console.WriteLine(
                $"\t So dau tien la: {a}" +
                $"\t So thu hai la: {b}");

        }
    }
}
