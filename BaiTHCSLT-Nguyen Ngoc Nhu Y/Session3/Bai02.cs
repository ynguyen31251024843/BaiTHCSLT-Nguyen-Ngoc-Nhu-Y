using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises3
{
    internal class Bai02
    {
        static void Maina2(string[] args)
        {
            Console.WriteLine("y\t x");

            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"{y}\t {x}");
            }
        }
    }
}
