using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1Chieu
{
    class Program
    {
        static int[] a = new int[100];
        static int length = 0;
        static void Main(string[] args)
        {
            NhapNgauNhien();
            Xuat(a,length);
            Console.Write("\nCac so chan cua mang la: ");
            int soPhanTu = 0;
            int[] kq = TimTatCaCacSoChan(ref soPhanTu);
            Xuat(kq, soPhanTu);
           
           
            Console.ReadKey();

        }
        static void Nhap()
        {
            Console.Write("Nhap vao so phan tu cua mang: ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] mang,int soPhanTu)
        {
            Console.Write("\n Mang  ");
            for (int i = 0; i < soPhanTu; i++)
            {
                Console.Write(mang[i] + "\t");
            }

        }
        static void NhapNgauNhien()
        {
            Console.Write("Nhap vao so phan tu cua mang: ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = r.Next(100);
            }
        }
        static int Tong()
        {
            int tong = 0;
            
            for(int i=0;i<length;i++)
            {
                tong = tong + a[i];
            }
            Console.Write("\nTong= "+ tong);
            return tong;
        }
        static int TimViTriDauTien(int x)
        {
            for(int i=0;i<length;i++)
            {
                if (a[i] == x)
                    return i;
            }
            return -1;
        }
        static int TimViTriCuoiCung(int x)
        {
            for(int i=length-1;i>=0;i--)
            {
                if (a[i] == x)
                    return i;
            }
            return -1;
        }
        static void XoaPhanTuTaiViTri(int vt)
        {
            for(int i=vt;i<length-1;i++)
            {
                a[i = 1] = a[i];
            }
            length--;
        }
        static void XoaPhanTuTaiViTriDauTien(int x)
        {
            XoaPhanTuTaiViTri(TimViTriDauTien(x));
        }
        static int[] TimTatCaCacSoChan(ref int soPhanTu)
        {
            int[] kq = new int[100];
            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    kq[soPhanTu++] = a[i];
                }
            }
            return kq;
        }

    }
}
