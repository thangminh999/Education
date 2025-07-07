using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapDe3
{
    public class LoaiMatHang
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public LoaiMatHang()
        {

        }

        public LoaiMatHang(DataRow row)
        {
            this.MaLoai = Convert.ToInt32(row["MaLoai"]);
            this.TenLoai = row["TenLoai"].ToString();
        }

        public LoaiMatHang(int maloai, string tenloai)
        {
            this.MaLoai = maloai;
            this.TenLoai = tenloai;
        }
    }
}
