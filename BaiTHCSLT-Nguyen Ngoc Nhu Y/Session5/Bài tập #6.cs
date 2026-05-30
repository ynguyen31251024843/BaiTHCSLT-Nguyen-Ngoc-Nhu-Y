using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Session5
{
    internal class Bài_tập_C_
    {
        public static void Mainy6(string[] args)
        {
            //ex01();
            //ex02();
            //ex03();
            //ex04();
            //ex05();
            //ex06();
            //ex07();
            //ex08();
            //ex09();
            //ex10();
        }

        //1.to calculate the average value of array elements.
        static double tinhtrungbinh(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            int tong = 0;
            foreach ( int so in arr)
            {
                tong = tong + so;
            }
            double ketqua = (double)tong / arr.Length;
            return ketqua;
        }

        static void ex01()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for ( int i = 0; i < mang.Length; i++ )
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());

            }
            double kq = tinhtrungbinh(mang);
            Console.WriteLine($"Trung binh cua mang la: {kq}");
        }

        //2.to test if an array contains a specific value.
        static bool timso(int[] arr, int n)
        {
            if (arr == null || arr.Length == 0)
                return false;
            foreach ( int so in arr)
            {
                if ( so == n ) return true;
            }
            return false;
        }
        static void ex02()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int a = int.Parse(Console.ReadLine());
            int[] mang = new int[a];
            for (int i = 0; i < mang.Length;i++)
            {
                Console.Write($"Nhap gia tri cua phan tu thu {i+1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap so can tim trong mang: ");
            int b = int.Parse(Console.ReadLine());
            bool kq = timso(mang, b);
            Console.Write($"Output: {kq}");
        }

        //3. tìm chỉ số của một phần tử trong mảng.
        static int timchiso(int[] arr, int n)
        {
            for ( int i = 0; i < arr.Length;i++)
            {
                if (arr[i] == n)
                    return i;
            }
            return -1;
        }
        static int timchisocuaphantu(int[] arr, int n)
        {
            return Array.IndexOf(arr, n);
        }

        static void ex03()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int a = int.Parse(Console.ReadLine());
            int[] mang = new int[a];
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhap gia tri cua phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap phan tu can tim chi so: ");
            int b = int.Parse(Console.ReadLine());
            int kq = timchisocuaphantu(mang, b);
            if (kq == -1)
                Console.WriteLine("Khong tim thay trong mang");
            else
                Console.WriteLine($"Output: {kq}");
        }

        //4. loại bỏ một phần tử cụ thể khỏi mảng.
        static int[] xoaphantu(int[] arr, int socanxoa)
        {
            int sotrung = 0;
            foreach (int so in arr)
            {
                if (so == socanxoa)
                    sotrung++;
            }
            if (sotrung == 0)
                return arr;
            int[] newarr = new int[arr.Length - sotrung];
            int chiso = 0;
            foreach (int so in arr)
            { 
                if ( so != socanxoa)
                {
                    newarr[chiso] = so;
                    chiso++;
                }
               
            }
            return newarr;

        }
        static void inmang(int[] arr)
        {
            foreach (int so in arr)
            {
                Console.Write($"{so} ");
                
            }
        }
        static int[] xoaptu(int[]arr,int socanxoa)
        {
            int[] newarr = arr.Where(so => so != socanxoa).ToArray();
            return newarr;
        }
        static void ex04()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap gia tri cho phan tu thu {i+1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap phan tu can xoa: ");
            int a = int.Parse(Console.ReadLine());
            int[] mangsaukhixoa = xoaphantu(mang, a);
            Console.Write("Mang sau khi xoa la: ");
            inmang(mangsaukhixoa);

        }

        //5. tìm giá trị lớn nhất và nhỏ nhất của một mảng.
        static int timgtln(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if ( arr[i] > max)
                {
                    max = arr[i];

                }
            }
            return max;
           
        }
        static int timgtnn(int[] arr)
        {
            int min = arr[0];
            foreach (int so in arr)
            {
                if (so < min)
                    min = so;
            }
            return min;
        }
        


        static void ex05()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int a = int.Parse(Console.ReadLine());
            int[] mang = new int[a];
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhap gia tri cua phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int kq = timgtln(mang);
            Console.WriteLine($"GTLN cua mang la: {kq}");
            int kq1 = timgtnn(mang);
            Console.WriteLine($"GTNN cua mang la: {kq1}");
        }

        //6. đảo ngược một mảng các giá trị số nguyên.
        static int[] daonguocmang(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }
        
        static void ex06()
        {
            Console.Write("Nhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap gia tri cho phan tu thu {i+1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int[] mangmoi = daonguocmang(mang);
            
            Console.Write("Mang sau khi dao nguoc la: ");
            inmang(mangmoi);

        }

        //7. tìm các giá trị trùng lặp trong một mảng giá trị.
        static int[] timgiatritrunglap(int[] arr)
        {
            int[] mangtam = new int[arr.Length];
            int soluongtrung = 0;
            for ( int i = 0; i <= arr.Length - 1; i++ )
            {
                for (int j = i + 1;  j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        bool dainchua = false;
                        for (int k = 0 ; k < i; k++)
                        {
                            if ((arr[k] == arr[i]))
                                dainchua = true;
                            break;

                        }
                        if (dainchua == false)
                        {
                            mangtam[soluongtrung] = arr[i];
                            soluongtrung++;
                        }
                        break;

                    }
                    
                }
            }
            int[] mangkq = new int[soluongtrung];
            for ( int i = 0; i < soluongtrung; i++ )
            {
                mangkq[i] = mangtam[i];
            }
            return mangkq;
        }
        static void inmangtrunglap( int[] mangtrunglap )
        {
            if (mangtrunglap.Length == 0)
                Console.WriteLine("Khong co phan tu trung lap");
            else
            {
                for ( int i = 0; i < mangtrunglap.Length;i++ )
                {
                    Console.Write($"Cac phan tu trung lap la: {mangtrunglap[i]} ");
                }
            }
        }
        static void ex07()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for ( int i = 0;i < n;i++ )
            {
                Console.Write($"Nhap gia tri cua phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int[] kq = timgiatritrunglap(mang);
           
            inmangtrunglap(kq);
        }

        //8. loại bỏ các phần tử trùng lặp khỏi một mảng 
        static int[] loaibophantutrunglap(int[] arr)
        {
            int[] mangtam = new int[arr.Length];
            int soluong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool datontai = false;
                for (int k = 0; k < i; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        datontai = true;
                        break;
                    }
                }
                if (datontai == false)
                {
                    mangtam[soluong] = arr[i];
                    soluong++;
                }
            }
            int[] mangkq = new int[soluong];
            for ( int i = 0; i < soluong; i++ )
            {
                mangkq[i] = mangtam[i];

            }
            return mangkq;
        }
        static void inmangdaloaibotrunglap(int[] arr)
        {
            if (arr.Length == 0)
                Console.WriteLine("Mang k bi trung lap");
            else
            {
                Console.Write("Mang sau khi da loai bo cac phan tu trung lap: ");
                for (int i = 0;i < arr.Length;i++)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
        static void ex08()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i = 0;i < n; i++)
            {
                Console.Write($"Nhap gia tri cua phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            int[] kq = loaibophantutrunglap(mang);
            inmangdaloaibotrunglap(kq);
            
        }

        //9. Yêu cầu người dùng nhập 10 số nguyên và sắp xếp chúng bằng cách thực hiện thuật toán sắp xếp nổi bọt.
        static int[] bubblesort(int[] arr)
        {
            for (int i = 0; i  < arr.Length - 1;i++)
            {
                for (int j =0; j < arr.Length -1 - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int tam = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tam;
                    }

                }
            }
            return arr;
        }
        static void ex09()
        {
            Console.WriteLine("Mang co 10 phan tu");
            int[] mang = new int[10];
            for ( int i = 0; i < 10; i++)
            {
                Console.Write($"Nhap gia tri phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine()) ;
            }
            int[] kq = bubblesort(mang);
            Console.Write("Mang sau khi sap xep: ");
            inmang(kq);

        }
        //10. Yêu cầu người dùng cung cấp một câu, sau đó yêu cầu nhập một từ. Tìm xem từ đó có xuất hiện trong câu hay không bằng thuật toán tìm kiếm tuyến tính.
        static int timtu(string[] cau, string tucantim)
        {
            for (int i = 0; i < cau.Length; i++)
            {
                if (cau[i].Equals(tucantim, StringComparison.OrdinalIgnoreCase))
                    return i;
                    
            }
            return -1;
        }
        static void ex10()
        {
            Console.Write("Nhap mot cau: ");
            string a = Console.ReadLine();
            Console.Write("Nhap tu can tim: ");
            string b = Console.ReadLine();
            string[] mangcactu = a.Split(' ');
            int kq = timtu(mangcactu, b);
            if (kq == -1)
                Console.WriteLine("Khong tim thay");
            else
                Console.WriteLine("Co xuat hien trong cau");
        }
    }
}
