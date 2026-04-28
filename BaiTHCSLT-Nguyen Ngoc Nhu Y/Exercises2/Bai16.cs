using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai16
    {
        static void Main16(string[] args)
        {
            Console.WriteLine("Hexadecimal to Decimal");
            Console.Write("Hexadecimal number: ");
            string hex = Console.ReadLine();
            int dec = Convert.ToInt32(hex , 16);
            Console.WriteLine($"Decimal number: {dec}");
        }
    }
}
