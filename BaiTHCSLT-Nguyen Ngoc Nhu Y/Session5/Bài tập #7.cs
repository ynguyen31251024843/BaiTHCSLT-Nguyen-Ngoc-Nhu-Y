using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Session5
{
    internal class Baitapslide
    {
        public static void Mainy2(string[] args)
        {
            //ex01();
        }
        //Tạo một ma trận số nguyên kích thước N x M (N, M được nhập từ người dùng) ngẫu nhiên.
        //In ma trận ra màn hình
        //In hàng thứ i / cột thứ i (i được nhập từ người dùng)
        static int[,] taomatran(int[,] arr, int rows, int cols)
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = random.Next(0, 100);
                }
            }
            return arr;
        }
        static void inmang(int[,]arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void indong(int[,]arr, int rows)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[rows,j]}\t");
            }
            
            
        }

       
        static void ex01()
        {
            Console.Write("Nhap so dong: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: "); int m = int.Parse(Console.ReadLine());
            int[,] mang = new int[n, m];
            int[,] kq = taomatran(mang,n, m);
            Console.WriteLine("Mang sau khi tao: ");
            inmang(kq);
            Console.Write("Nhap dong can in: "); int rows = int.Parse(Console.ReadLine());
            indong(mang, rows - 1);

        }
    }
}
