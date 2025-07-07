using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapDe3
{
    public class MatHang
    {
        public int MaMH { get; set; }
        public string TenMH { get; set; }
        public int MaLoai { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        public MatHang()
        {

        }

        public MatHang(DataRow row)
        {
            this.MaMH = Convert.ToInt32(row["MaMatHang"]);
            this.TenMH = row["TenMatHang"].ToString();
            this.MaLoai = Convert.ToInt32(row["MaLoai"]);
            this.SoLuong = Convert.ToInt32(row["SoLuong"]);
            this.DonGia = Convert.ToInt32(row["DonGia"]);
        }

        public MatHang(int mamh, string tenmh, int maloai, int soluong, int dongia)
        {
            this.MaMH = maloai;
            this.TenMH = tenmh;
            this.MaLoai = maloai;
            this.SoLuong = soluong;
            this.DonGia = dongia; 
        }
    }
}
