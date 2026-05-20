using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai07
    {
        static void Main7(string[] args)
        {
            Console.WriteLine("Multiplication Table");
            int a;
            Console.Write("Nhap mot so: ");
            a = int.Parse(Console.ReadLine());
            for (int n = 0; n <= 10; n++)
            {
                Console.WriteLine($"{a} * {n} = {a * n}");
            }

        }
    }
}
