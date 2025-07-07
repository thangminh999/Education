using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PhanSo a = new PhanSo();
            //a.Xuat();
            //a.Nhap();
            //a.Xuat();
            
            //PhanSo b = new PhanSo();
            //b.Xuat();
            //b = a;
            //b.Xuat();
            //Console.ReadLine();
            PhanSo a = new PhanSo(1, 2);
            a.Xuat();
           
            PhanSo b = new PhanSo(4, 5);
            b.Xuat();
            PhanSo c = a.Cong(a, b);
            c.Xuat();
            Console.ReadLine();
        }
    }
}
