using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises1
{
    internal class Bai07
    {
        static void Maing(string[] args)
        {
            Console.WriteLine("Print ASCII Value");
            Console.Write("Nhap 1 ky tu: ");
            char kt = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int ascii = (int)kt;
            Console.WriteLine($"Gia tri ASCII cua {kt} la: {ascii}");
        }
    }
}
