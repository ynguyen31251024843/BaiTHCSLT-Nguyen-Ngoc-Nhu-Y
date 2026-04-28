using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai11
    {
        static void Main11(string[] args)
        {
            Console.WriteLine(" Celsius to Kelvin and Fahrenheit ");
            float a;
            Console.Write("Nhap do C: ");
            a = float.Parse(Console.ReadLine());
            float dok = a + 273f;
            float dof = (a * 1.8f) + 32f;
            Console.WriteLine($"\t Kelvin: {dok} \n" +
                $"\t Fahrenheit: {dof} \n");
        }
    }
}
