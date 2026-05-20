using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai15
    {
        static void Main15(string[] args)
        {
            Console.WriteLine("Convert String to Lowercase");
            Console.Write("Enter a string: ");
            string vao = Console.ReadLine();
            string ra = vao.ToLower();
            Console.WriteLine($"Lowercase: {ra}");
        }
    }
}
