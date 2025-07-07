using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCPU
{
    class CPU
    {
        public string ten;
        public string hang;
        public double giaTien;
        public int namSX;
        public double tocDoCPU;
        public void Nhap()
        {
            Console.Write("Nhap ten san pham: ");
            ten = Console.ReadLine();
            Console.Write("Nhap ten hang cua san pham: ");
            hang = Console.ReadLine();
            Console.Write("Nhap gia tien san pham: ");
            giaTien = int.Parse(Console.ReadLine());
            Console.Write("Nhap toc do xu ly cua san pham: ");
            tocDoCPU = double.Parse(Console.ReadLine());
            Console.Write("Nam san xuat: ");
            namSX = int.Parse(Console.ReadLine());



        }
        public void Xuat()
        {
            Console.WriteLine("ten San Pham\t\tTen hang\tNam san xuat\tGia tien\tToc do xu ly");
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4} ", ten, hang, namSX,giaTien+"VND", tocDoCPU+"GHz");
        }
    }
}
