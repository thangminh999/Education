using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocPhan
{
    class HocPhan
    {
        public string maHocPhan;
        public string tenHocPhan;
        public int soTinChi;
        public bool loaiHocPhan;
        public void Nhap()
        {
            Console.Write("Nhap ma hoc phan: ");
            maHocPhan = Console.ReadLine();
            Console.Write("Nhap ten hoc phan: ");
            tenHocPhan = Console.ReadLine();
            Console.Write("Nhap so tin chi hoc phan: ");
            soTinChi = int.Parse(Console.ReadLine());
            Console.Write("Hoc phan tu chon hay bat buoc(0: TC/1 : BB): ");
            loaiHocPhan = (Console.ReadLine()== "1" ? true : false);
           


        }
        public void Xuat()
        {
            Console.WriteLine("ma hoc phan\tTen hoc phan\tSo tin chi\tLoai Hoc Phan");
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3} ",maHocPhan,tenHocPhan,soTinChi,loaiHocPhan ? "Bat buoc":"Tu chon" );
        }
    }
}
