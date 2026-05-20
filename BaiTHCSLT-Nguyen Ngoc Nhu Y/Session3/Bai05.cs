using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises3
{
    internal class Bai05
    {
        static void Maina5(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if ("aeiouAEIOU".Contains(ch))
            {
                Console.WriteLine("It is a vowel.");
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine("It is a digit.");
            }
            else
            {
                Console.WriteLine("It is another symbol.");
            }
        }
    }
}
