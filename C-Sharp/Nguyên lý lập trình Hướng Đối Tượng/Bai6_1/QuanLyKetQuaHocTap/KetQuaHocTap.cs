using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKetQuaHocTap
{
    class KetQuaHocTap
    {
        public string maHocPhan;
        public string tenHocPhan;
        public int soTinChi;
        public int diem;
        public void Nhap()
        {
            Console.Write("Nhap ma hoc phan: ");
            maHocPhan = Console.ReadLine();
            Console.Write("Nhap ten hoc phan: ");
            tenHocPhan = Console.ReadLine();
            Console.Write("Nhap so tin chi hoc phan: ");
            soTinChi = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem cua hoc phan: ");
            diem = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("ma hoc phan\tTen hoc phan\tSo tin chi\tdiem");
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3} ", maHocPhan, tenHocPhan, soTinChi, diem);
        }
    }
}
