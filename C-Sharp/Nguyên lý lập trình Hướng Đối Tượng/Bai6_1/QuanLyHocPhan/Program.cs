using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocPhan
{
    class Program
    {
        static void Main(string[] args)
        {
            HocPhan a = new HocPhan();
            a.Nhap();
            a.Xuat();
            Console.ReadLine();
        }
    }
}
