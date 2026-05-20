using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises2
{
    internal class Bai10
    {
        static void Main10(string[] args)
        {
            Console.WriteLine("Print Age Message");
            int age;
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {age}");
            
        }
    }
}
