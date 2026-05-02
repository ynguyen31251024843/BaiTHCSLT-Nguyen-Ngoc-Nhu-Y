using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Exercises3
{
    internal class Bai03
    {
        static void Maina3(string[] args)
        {
            Console.Write("Enter distance (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter seconds: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double totalHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            double speedKmH = distance / totalHours;
            double speedMilesH = speedKmH * 0.621371;

            Console.WriteLine("Speed in km/h: " + speedKmH);
            Console.WriteLine("Speed in miles/h: " + speedMilesH);
        }
    }
}
