using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCPU
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU a = new CPU();
            a.Nhap();
            a.Xuat();
            Console.ReadLine();
        }
    }
}
