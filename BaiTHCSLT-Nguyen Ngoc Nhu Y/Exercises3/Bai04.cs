using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises3
{
    internal class Bai04
    {
        static void Maina4(string[] args)
        {
            Console.Write("Enter radius: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double surface = 4 * Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);

            Console.WriteLine("Surface area: " + surface);
            Console.WriteLine("Volume: " + volume);
        }
    }
}
