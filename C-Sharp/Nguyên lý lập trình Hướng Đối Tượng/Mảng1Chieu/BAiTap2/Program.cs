using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAiTap2
{
    class Program
    {
        static int[] a = new int[100];
        static int length = 0;

        static void Main(string[] args)
        {
            Nhap();
            Xuat();
            
            Console.Write("\nNhap gia tri x can tim trong mang: ");
            int x = int.Parse(Console.ReadLine());
            TimViTriDauTien(x);
            
            

            Console.ReadKey();

        }
        static void Nhap()
        {
            Console.Write("Nhap vao phan tu cua mang: ");
            length = int.Parse(Console.ReadLine());
            for(int i=0;i<length;i++)
            {
                Console.Write("a[{0}]: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat()
        {
            Console.WriteLine("Mang vua nhap la: ");
            for(int i=0;i<length;i++)
            {
                Console.Write("\t" + a[i]);
            }
        }
        static void NhapNgauNhien()
        {
            Console.Write("Nhap vao so phan tu cua mang: ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i=0;i<length;i++)
            {
                Console.Write("a[{0}]: ",i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void tong()
        {
            int tong = 0;
            for(int i=0;i<length;i++)
            {

                tong = tong+a[i];

               

            }
            Console.Write("\nTong=" + tong);


        }
        static int TimViTriDauTien(int x)
        {
            for(int i=0;i<length;i++)
            {
                if (a[i] == x)
                    return i;
                Console.Write("Vi tri x dau tien trong mang la: ");

            }
            return -1;
        }
    }
}
