using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class LoaiMatHang
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public LoaiMatHang()
        {

        }
        public LoaiMatHang(int maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }
    }
}
