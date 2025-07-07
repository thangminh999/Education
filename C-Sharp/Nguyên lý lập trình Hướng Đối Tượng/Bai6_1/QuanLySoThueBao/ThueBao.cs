using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoThueBao
{
    class ThueBao
    {
        public string soDienThoaiKhachHang;
        public string hoTenKhachHang;
        public string diaChi;
        public void Nhap()
        {
            Console.Write("Nhap sdt cua khach hang:");
            soDienThoaiKhachHang = Console.ReadLine();
            Console.Write("Nhap ho va ten cua khach hang:");
            hoTenKhachHang = Console.ReadLine();
            Console.Write("Nhap dia chi cua khach hang:");
            diaChi = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ho va Ten\t\tSDT\t\t\tDia Chi");
            Console.WriteLine("{0}\t\t{1}\t\t{2} ", hoTenKhachHang,soDienThoaiKhachHang,diaChi);
        }
    }
}
