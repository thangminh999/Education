using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class MatHang
    {
        public int MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public int TenLoai { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public MatHang()
        {

        }

        public MatHang(int maMH, string tenMH, int tenLoai, int soLuong, int donGia)
        {
            MaMatHang = maMH;
            TenMatHang = tenMH;
            TenLoai = tenLoai;
            SoLuong = soLuong;
            DonGia = donGia;
        }
    }
}
