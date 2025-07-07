using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoThueBao
{
    class Program
    {
        static void Main(string[] args)
        {
            ThueBao a = new ThueBao();
            a.Nhap();
            
            a.Xuat();
            Console.ReadLine();
        }
    }
}
