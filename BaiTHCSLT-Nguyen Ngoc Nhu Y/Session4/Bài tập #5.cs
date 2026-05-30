

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Session4
{
    internal class Bài_tập__
    {
        public static void Mainy1(string[] args)
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
            //ex11();
            //ex12();
            //ex13();
            //ex14();
            //ex15();
            //ex16();
            //ex17();
            //ex18();
            //ex19();
            //ex20();
        }
        //Bài 1: Tính tổng hai số nguyên 
        static int tong(int a, int b)
        {
            return a + b;
        }
        static void ex01()
        {
            int x, y;
            x = 10;
            y = 20;
            int kq = tong(x, y);
            Console.WriteLine($"Sum {x} + {y} = {kq}");
        }

        //Bài 2: Kiểm tra số chẵn lẻ 
        static bool kiemtra(int a)
        {
           if (a % 2 == 0) 
                return true;
           else
                return false;
        }
        static void ex02()
        {
            int x = 10;
            bool kq = kiemtra(x);
            if (kq == true)
                Console.WriteLine($"{x} la so chan");
            else
                Console.WriteLine($"{x} la so le");
             
        }
        //Bài 3: Tìm số lớn nhất trong ba số
        static int timsolonnhat(int a, int b, int c)
        {
            int max = Math.Max(a, Math.Max(b, c));
            return max;

        }
        static void ex03()
        {
            int x = 23;
            int y = 34;
            int z = 2;
            int kq = timsolonnhat(x, y, z);
            Console.WriteLine($"So lon nhat trong 3 so {x}, {y}, {z} la {kq}");
        }

        //Bài 4: Tính giai thừa của một số 
        static long timgiaithua(int n)
        {
            long giaithua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;
            }
            return giaithua;

        }
        static void ex04()
        {
            
            Console.Write("Nhap 1 so: ");
            int a = int.Parse(Console.ReadLine());
            long kq = timgiaithua(a);
            Console.WriteLine($"Giai thua cua {a} la: {kq}");

        }

        //Bài 5: Đảo ngược chuỗi ký tự
        static string daonguocchuoi(string input)
        {
            char[] mangkytu = input.ToCharArray();
            Array.Reverse(mangkytu);
            return new string (mangkytu);
        }
        static void ex05()
        {
            Console.Write("Nhap mot chuoi ky tu: ");
            string chuoi= Console.ReadLine();
            string kq = daonguocchuoi(chuoi);
            Console.WriteLine($"Chuoi sau khi bi dao nguoc: {kq}");
        }

        //Bài 6: Kiểm tra số nguyên tố 
        //Yêu cầu: Viết hàm `bool KiemTraNguyenTo(int n)` kiểm tra xem số nguyên n có phải số nguyên tố hay không.
        //Kết quả mẫu: Input: 7 -> Output: True | Input: 10 -> Output: False
        static bool kiemtranguyento(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
                   
        }
        static void ex06()
        {
            Console.Write("Nhap so can kiem tra: ");
            int a = int.Parse(Console.ReadLine());
            bool kq = kiemtranguyento(a);
            if (kq == true)
                Console.WriteLine($"{a} la so nguyen to");
            else
                Console.WriteLine($"{a} khong phai la so nguyen to");
        }

        //Bài 7: In dãy Fibonacci 
        //Yêu cầu: Viết hàm `void InFibonacci(int n)` in ra n số đầu tiên của dãy Fibonacci. 
        //Kết quả mẫu: Input: 6 -> Output: 0 1 1 2 3 5 
        static void infibonacci(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("So luong phan tu phai lon hon 0");
                return;
            }
            if (n == 1)
            {
                Console.WriteLine("0");
                return;
            }
            int f0 = 0;
            int f1 = 1;
            Console.Write($"{f0} {f1} ");
            for (int i = 2; i < n; i++)
            {
                int fn = f0 + f1;
                Console.Write($"{fn} " );
                f0 = f1;
                f1 = fn;
            }
            
        }
        static void ex07()
        {
            Console.Write("Input: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write($"Output: ");
            infibonacci(a);

        }

        //Bài 8: Đếm số lượng nguyên âm trong chuỗi 
        //Yêu cầu: Viết hàm `int DemNguyenAm(string s)` đếm số lượng các ký tự nguyên âm(a, e, i, o,
        //u) trong chuỗi.
        //Kết quả mẫu: Input: "Hello World" -> Output: 3
        static int demnguyenam(string c)
        {
            int soluong = 0;
            string chuoi = c.ToLower();
            foreach (char kytu in chuoi)
            {
                if ( kytu == 'u' || kytu == 'e' || kytu == 'o' || kytu == 'a' || kytu == 'i')
                {
                    soluong++;

                }

            }
            return soluong;
        }
        static void ex08()
        {
            Console.Write("Nhap chuoi can dem nguyen am: ");
            string a = Console.ReadLine();
            int kq = demnguyenam(a);
            Console.WriteLine($"Chuoi: {a}" +
                 $"\nSo luong nguyen am la: {kq}");
        
        }

        //Bài 9: Tính lũy thừa 
        //Yêu cầu: Viết hàm `double TinhLuyThua(double x, int y)` tính x^y(không dùng Math.Pow). 
        //Kết quả mẫu: Input: x = 2, y = 3 -> Output: 8
        static double tinhluythua(double x, int y)
        {
            double so = 1;
            for (int i = 1; i <= y; i++)
            {
                so = so * x;
            }
            return so;
        }
        static void ex09()
        {
            Console.Write("Nhap co so: ");
            double coso = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu: ");
            int somu = int.Parse(Console.ReadLine());
            double kq = tinhluythua(coso, somu);
            Console.WriteLine($"Input co so = {coso}" +
                $"\t so mu = {somu} -> Output = {kq}");
        }

        //Bài 10: Tính điểm trung bình của mảng 
        //Yêu cầu: Viết hàm `double TinhTrungBinh(int[] arr)` tính giá trị trung bình của mảng số nguyên.
        //Kết quả mẫu: Input: [4, 5, 6, 7] -> Output: 5.5 
        static double tinhtrungbinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int tong = 0;
            foreach (int so in arr)
            {
                tong = tong + so;
            }
            double trungbinh = (double)tong / arr.Length;
            return trungbinh;
        }
        static void ex10()
        {
            Console.Write("Nhap so luong phan tu cho mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int [n];
            
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhap gia tri cho phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
            double kq = tinhtrungbinh(mang);
            Console.WriteLine($"Diem trung binh cua mang la: {kq}");
        }

        //Bài 11: Kiểm tra chuỗi đối xứng (Palindrome) 
        //Yêu cầu: Viết hàm `bool KiemTraDoiXung(string s)` kiểm tra chuỗi có đọc xuôi và ngược giống nhau không.
        //Kết quả mẫu: Input: "radar" -> Output: True | Input: "hello" -> Output: False
        static bool kiemtradoixung(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
                return true;
            string chuoi = s.ToLower();
            for (int i = 0; i < chuoi.Length / 2;  i++)
            {
                int vitricuoi = chuoi.Length - 1 - i;
                if (chuoi[i] != chuoi[vitricuoi])
                    return false;
            }
            return true;
        }
        static void ex11()
        {
            Console.Write("Nhap chuoi can kiem tra doi xung: ");
            string a = Console.ReadLine();
            bool kq = kiemtradoixung(a);
            if (kq)
                Console.WriteLine($"{a} la chuoi doi xung");
            else Console.WriteLine($"{a} la chuoi khong doi xung");

        }

        //Bài 12: Chuyển đổi nhiệt độ 
        //Yêu cầu: Viết hàm `double CelsiusToFahrenheit(double c)` chuyển đổi từ độ C sang độ F.
        //Kết quả mẫu: Input: 25 -> Output: 77
        static double celciustofahrenheit(double c)
        {
            double f = c * 1.8 + 32;
            return f;
        }
        static void ex12()
        {
            Console.Write("Nhap nhiet do Celsius can doi: ");
            double a = double.Parse(Console.ReadLine());
            double kq = celciustofahrenheit(a);
            Console.WriteLine($"{a} khi doi qua Fahrenheit la {kq}");
        }

        //Bài 13: Tìm giá trị nhỏ nhất trong mảng 
        //Yêu cầu: Viết hàm `int TimMin(int[] arr)` trả về phần tử nhỏ nhất trong mảng.
        //Kết quả mẫu: Input: [10, 5, 8, 2, 9] -> Output: 2
        static int timmin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        static void ex13()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int [n];
            for (int i = 0;  i < mang.Length; i++)
            {
                Console.Write($"Nhap gia tri cho phan tu thu {i+1}: ");
                mang[i] = int.Parse (Console.ReadLine());

            }
            int nho = timmin(mang);
            Console.WriteLine($"Gia tri nho nhat trong mang la: {nho}");
        }

        //Bài 14: Tính tổng các chữ số của một số nguyên 
        //Yêu cầu: Viết hàm `int TongCacChuSo(int n)` để tính tổng từng chữ số tạo nên n.
        //Kết quả mẫu: Input: 1234 -> Output: 10  (Vì 1+2+3+4 = 10)
        static int tongcacchuso(int n)
        {
            int tong = 0;
            if (n < 0)
                n = Math.Abs (n);
            while (n > 0)
            {
                int socuoi = n % 10;
                tong = tong + socuoi;
                n = n / 10;
            }
            return tong;
        }
        static void ex14()
        {
            Console.Write("Nhap so nguyen de tinh tong: ");
            int a = int.Parse(Console.ReadLine());
            int kq = tongcacchuso(a);
            Console.WriteLine($"Tong cac chu so la: {kq}");

        }

        //Bài 15: Sắp xếp mảng tăng dần 
        //Yêu cầu: Viết hàm `void SapXepMang(int[] arr)` sắp xếp và in ra mảng tăng dần.
        //Kết quả mẫu: Input: [3, 1, 4, 2] -> Output: 1 2 3 4
        static void sapxepmang(int[] arr)
        {
            for ( int i  = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int tam = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tam;
                    }
                }
            }
        }
        static void ex15()
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            for (int i  = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhap gia tri cho phan tu thu {i+1}: ");
                mang[i] = int.Parse(Console.ReadLine());

            }
            sapxepmang(mang);
            Console.WriteLine($"Mang sau khi sap xep theo thu tu tang dan: ");
            foreach ( int so in mang)
            {
                Console.Write( so + " " );
            }

        }

        //Bài 16: Xóa ký tự trùng lặp 
        //Yêu cầu: Viết hàm `string XoaTrungLap(string s)` trả về chuỗi với các ký tự xuất hiện lần đầu tiên được giữ lại.
        //Kết quả mẫu: Input: "programming" -> Output: "progamin" 
        static string xoatrunglap(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            string chuoi = "";
            foreach (char kytu in s)
            {
                if (!chuoi.Contains(kytu.ToString()))
                    chuoi = chuoi + kytu;
            }
            return chuoi;
        }
        static void ex16()
        {
            Console.Write("Nhap chuoi muon xoa ky tu trung lap: ");
            string a = Console.ReadLine();
            string kq = xoatrunglap(a);
            Console.WriteLine($"Input: {a}" +
                $"\nOutput: {kq}");
        }

        //Bài 17: Tìm ước chung lớn nhất (UCLN) 
        //Yêu cầu: Viết hàm `int UCLN(int a, int b)` sử dụng thuật toán Euclid để tìm UCLN của 2 số.
        //Kết quả mẫu: Input: a = 12, b = 18 -> Output: 6
        static int ucln(int a, int b)
        {
            while (b != 0)
            {
                int phandu = a % b;
                a = b;
                b = phandu;
            }
            return a;
        }
        static void ex17()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            int kq = ucln(a, b);
            Console.WriteLine($"Input a = {a},b = {b}" +
                $"\nOutput = {kq}");
        }

        //Bài 18: Chuyển đổi hệ thập phân sang nhị phân 
        //Yêu cầu: Viết hàm `string DecimalToBinary(int n)` nhận vào số thập phân và trả về chuỗi nhị phân.
        //Kết quả mẫu: Input: 10 -> Output: "1010"
        static string decimaltobinary(int n)
        {
            if (n == 0) return "0";
            n = Math.Abs(n);
            string chuoinhiphan = "";
            while (n > 0)
            {
                int sodu = n % 2;
                chuoinhiphan = sodu + chuoinhiphan;
                n = n / 2;
            }
            return chuoinhiphan;
        }
        static void ex18()
        {
            Console.Write("Nhap so can doi sang he nhi phan: ");
            int a = int.Parse(Console.ReadLine());
            string kq = decimaltobinary(a);
            Console.WriteLine($"Input = {a}" +
                $"\tOutput = {kq}");
        }

        //Bài 19: Kiểm tra năm nhuận 
        //Yêu cầu: Viết hàm `bool KiemTraNamNhuan(int year)` kiểm tra xem một năm có phải năm nhuận không.
        //Kết quả mẫu: Input: 2024 -> Output: True | Input: 2023 -> Output: False
        static bool kiemtranamnhuan(int y)
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                return true;
            else return false;
            
        }
        static void ex19()
        {
            Console.Write("Nhap nam can kiem tra: ");
            int a = int.Parse(Console.ReadLine());
            bool kq = kiemtranamnhuan (a);
            Console.WriteLine($"Input: {a}" +
                $"\tOutput: {kq}");

        }

        //Bài 20: Đếm số từ trong câu 
        //Yêu cầu: Viết hàm `int DemSoTu(string sentence)` trả về số lượng từ có trong câu.
        //Kết quả mẫu: Input: "Học lập trình C# rất thú vị" -> Output: 7
        static int demsotu(string cau)
        {
            if (string.IsNullOrWhiteSpace(cau))
                return 0;
            string[] cactu = cau.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return cactu.Length;
        }
        static void ex20()
        {
            Console.Write("Nhap cau de dem so luong tu: ");
            string a = Console.ReadLine();
            int kq = demsotu(a);
            Console.WriteLine($"Input: {a}" +
                $"\tOutput: {kq}");
        }
    }
}
