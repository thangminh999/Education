using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class PhanSo
    {
        public int tu;
        public int mau;
        public void Nhap()
        {
            Console.Write("Nhap tu");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau");
            mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", tu, mau);
        }
        public PhanSo(int t,int m)
        {
            tu = t;
            mau = m;
        }
        public PhanSo()
        {
            mau = 1;
        }
        public PhanSo Cong(PhanSo a,PhanSo b)
        {
            PhanSo kq = new PhanSo();
            kq.tu = a.tu * b.mau + b.tu * a.mau;
            kq.mau = a.mau * b.mau;
            return kq;
        }
    }
}
