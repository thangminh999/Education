using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien a = new SinhVien();
            a.Nhap();
            a.Xuat();
            Console.ReadLine();
        }
    }
}
