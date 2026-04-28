using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai09
    {
        static void Main9(string[] args)
        {
            Console.WriteLine("Specified Formula with Three Numbers");
            float x, y, z;
            Console.Write("Nhap x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            y = float.Parse(Console.ReadLine());
            Console.Write("Nhap z: ");
            z = float.Parse(Console.ReadLine());
            Console.WriteLine($"({x} + {y}) * {z} = {(x + y) * z}");
            Console.WriteLine($"{x} * {y} + {y} * {z} = {x * y + y * z}");
        }
    }
}
