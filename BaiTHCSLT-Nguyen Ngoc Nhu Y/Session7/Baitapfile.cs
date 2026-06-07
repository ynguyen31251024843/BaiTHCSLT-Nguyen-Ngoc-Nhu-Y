using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace BaiTHCSLT_Nguyen_Ngoc_Nhu_Y.Session_7
{
    internal class Baitapfile
    {
        //1.to create a blank file on the disk.

        static void taofiletrong(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                Console.WriteLine("Tao file thanh cong");
            }
            else Console.WriteLine("File da co tu truoc roi");
        }
        public static void Main1(string[] args)
        {
            string tenfile = "filetrong.txt";
            taofiletrong(tenfile);
            string duongdan = Path.GetFullPath(tenfile);
            Console.WriteLine($"{duongdan}");

        }

        //2.to remove a file from the disk.
        static void xoafile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    Console.WriteLine("Da xoa thanh cong");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else Console.WriteLine("File nay khong ton tai");

        }
        public static void Main2(string[] args)
        {
            string filecanxoa = "filetrong.txt";
            xoafile(filecanxoa);
        }

        //3.tạo một tệp và thêm một số văn bản.
        static void taofilevathemtext(string path)
        {
            if (!File.Exists(path))
            { File.Create(path).Close(); }
            string[] text = new string[] { "Hello world", "Day la bai tap C#" };
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (string c in text)
                    { sw.WriteLine(c); }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void Main3(string[] args)
        {
            string file = "a.txt";
            taofilevathemtext(file);
            Console.WriteLine("Done");
        }

        //4.tạo một tệp văn bản và đọc nó.
        static void taovadoc(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    using(StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else Console.WriteLine("File khong ton tai"); 
        }
        
        public static void Main4(string[] args)
        {
            string filecandoc = "a.txt";
            taovadoc(filecandoc);

        }

        //6.thêm một số văn bản vào một tệp hiện có.
        //cach 1:
        static void themvanban(string path, string add)
        {
            if(File.Exists(path))
            {
                try
                {
                    File.AppendAllText(path, add);
                    Console.WriteLine("Done");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else Console.WriteLine("Khong tim thay file de them");
        }
        //Cach 2:
        static void themvanban2(string path,string add)
        {
            if(File.Exists(path))
            {
                try
                {
                    using(StreamWriter sr = new StreamWriter(path,true))
                    {
                        sr.WriteLine();
                        sr.WriteLine(add);
                        Console.WriteLine("Done");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else Console.WriteLine("Khong tim thay file");
        }
        public static void Main6(string[] args)
        {
            string file = "a.txt";
            Console.Write("Chuoi can them: ");
            string a = Console.ReadLine();
            themvanban(file, a);
        }

        //5.tạo một tệp và ghi một mảng các chuỗi vào tệp
        static void ghimang(string path, string[] add)
        {
            if (!File.Exists(path))
                File.Create(path);
            try
            {
                using(StreamWriter sr =new StreamWriter(path))
                {
                    foreach(string s in add)
                        sr.WriteLine(s);
                    Console.WriteLine("Done");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ghimang2(string path, string[] add)
        {
            if (!File.Exists(path))
                File.Create(path);
            try
            {
                File.WriteAllLines(path, add);
                Console.WriteLine("Done");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main5(string[] args)
        {
            string[] idol = new string[]
                {
                    "Martin",
                    "Juhoon",
                    "James",
                    "Seonghyeon",
                    "Keonho"
                };
            string file = "i2.txt";
            ghimang2(file,idol);
        }

        //7.tạo và sao chép tệp sang tên khác và hiển thị nội dung.
        static void saochepvahienthi(string path, string copy)
        {
            if (!File.Exists(path))
                File.Create(path);

            try
            {
                string[] idol = new string[]
                {
                    "Martin",
                    "Juhoon",
                    "James",
                    "Seonghyeon",
                    "Keonho"
                };
                File.WriteAllLines(path, idol);
                File.Copy(path, copy, true);
                Console.WriteLine("Da sao chep thanh cong");
                //string noidung = File.ReadAllText(copy);
                using(StreamReader sr = new StreamReader(copy))
                {
                    string line;
                    while((line = sr.ReadLine()) != null )
                    {
                        Console.WriteLine(line);
                    }
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main7(string[] args)
        {
            string file = "idol.txt";
            string filecopy = "member.txt";
            saochepvahienthi(file, filecopy);
        }

        //8.tạo một tệp và di chuyển nó vào cùng thư mục với một tên khác.

        static void dichuyenfile(string path1, string path2)
        {
            if (!File.Exists(path1))
                File.Create(path1);
            try
            {
                string nd = "Day la bai tap C#";
                File.WriteAllText(path1, nd);
                if(File.Exists(path2))
                    File.Delete(path2);
                File.Move(path1, path2);
                Console.WriteLine("Done");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main8(string[] args)
        {
            string tendau = "tendau.txt";
            string tenmoi = "tenmoi.txt";
            dichuyenfile(tendau, tenmoi);
        }

        //9.read the first line of a file.
        static void docdongdautien(string path)
        {
            if (!File.Exists(path))
                Console.WriteLine("File khong ton tai"); return;

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    string dongdau = sr.ReadLine();
                    if(dongdau != null)
                        Console.WriteLine(dongdau);
                    else Console.WriteLine("File trong");
                }
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //if( File.Exists(path))
        //  {
        //    string dongdau = File.Readline(path).FirstOrDefault();
        //    Console.WriteLine(dongdau);
        //  }
        public static void Main9(string[] args)
        {
            string file = "b.txt";
            Console.WriteLine("Dong dau trong file la: ");
            docdongdautien(file);
        }

        //10.tạo và đọc dòng cuối cùng của một tệp.
        static void docdongcuoi(string path)
        {
           
            string[] mem = new string[] { "Martin", "James", "Juhoon", "Seonghyeon", "Keonho" };
            File.WriteAllLines(path,mem);
            try
            {
                string dongcuoi = null;
                string donghientai;
                using(StreamReader sr = new StreamReader(path))
                {
                    while((donghientai = sr.ReadLine()) != null)
                    {
                        dongcuoi = donghientai;
                    }
                }
                if(dongcuoi != null)
                    Console.WriteLine(dongcuoi);
                else Console.WriteLine("File trong");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void Main10(string[] args)
        {
            string file = "b.txt";
            Console.WriteLine("Dong cuoi la: ");
            docdongcuoi(file);
        }

        //12.đọc một dòng cụ thể từ một tệp.
        static void docdongcuthe(string path, int n)
        {
            if (!File.Exists(path))
            { Console.WriteLine("File khong ton tai");return; }
            if (n <= 0) { Console.WriteLine("So dong phai lon hon 0"); return; }
            try
            {
                string dong = null;
                string donghientai;
                int dem = 0;
                using(StreamReader sr = new StreamReader(path))
                {
                    while((donghientai = sr.ReadLine()) != null)
                    {
                        dem++;
                        if(dem == n)
                        {
                            dong = donghientai;
                            break;
                        }
                    }
                }
                if(dong != null)
                    Console.WriteLine(dong);
                else Console.WriteLine($"File khong co dong thu {n}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void Main12(string[] args)
        {
            string file = "idol.txt";
            Console.Write("Nhap so dong can in: ");
            int so = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua: ");
            docdongcuthe(file, so);
        }

        //13.đếm số dòng trong một tệp.
        static void demsodong(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File khong ton tai");
                return;

            }
            try
            {
                int dem = 0;
                string donghientai;
                using (StreamReader sr = new StreamReader(path))
                {
                   
                    while((donghientai = sr.ReadLine()) != null)
                    {
                        dem++;
                    }
                }
                if (dem != 0)
                {
                    Console.WriteLine(dem);
                }
                else Console.WriteLine("File trong");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        // int tongsodong = File.ReadLine(path).Count();
        public static void Main13(string[] args)
        {
            string file = "idol.txt";
            Console.Write("So dong co trong file la: ");
            demsodong(file);
        }

        //14.tạo mảng số 2 chieu random trong file 
        static void taomangso(string path, int[,] arr)
        {
            if(!File.Exists(path))
            {
                File.Create(path).Close();
            }
            Random random = new Random();
            try
            {
                using(StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine();
                    for(int i = 0; i < arr.GetLength(0); i++)
                    {
                        for(int j = 0; j < arr.GetLength(1); j++)
                        {
                            arr[i, j] = random.Next(0, 100);
                            sw.Write($"{arr[i, j]} ");
                            
                        }
                        sw.WriteLine();
                        
                    }
                    int kq = xuly(arr);
                    sw.Write($"So phan tu chia het cho 2 la: {kq}");
                  
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int xuly(int[,]arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.GetLength(0);i++)
            {
                for (int j =0;  j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0)
                        dem++;
                }
            }
            return dem;
        }
        public static void Main14(string[] args)
        {
            string file = "c.txt";
            Console.Write("Nhap so dong: ");
            int dong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            int cot = int.Parse(Console.ReadLine());
            int[,] arr = new int[dong, cot];
            taomangso(file,arr);
            Console.WriteLine("Done");
        }

    }
}
