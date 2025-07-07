using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKetQuaHocTap
{
    class Program
    {
        static void Main(string[] args)
        {
            KetQuaHocTap a = new KetQuaHocTap();
            a.Nhap();
            a.Xuat();
            Console.ReadLine();
        }
    }
}
