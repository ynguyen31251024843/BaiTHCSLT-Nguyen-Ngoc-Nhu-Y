using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai13
    {
        static void Main13(string[] args)
        {
            Console.WriteLine("Sum or Triple Sum of Integers");
            int a, b;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                int sum = (a + b) * 3;
                Console.WriteLine($"Ket qua la: {sum}");
               
            }
            else
            {
                int sum = a + b;
                Console.WriteLine($"Ket qua la: {sum}");
                
            }
        }
    }
}
