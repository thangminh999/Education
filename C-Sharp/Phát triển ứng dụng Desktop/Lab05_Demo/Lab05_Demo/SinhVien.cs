using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Demo
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTenLot { get; set; }
        public DateTime NgaySinh { get; set; }
        public string CMND { get; set; }
        public bool GioiTinh { get; set; }
        public string Ten { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        public List<string> MonHoc { get; set; }



        public SinhVien()
        {

        }

        public SinhVien(string mssv, string hotenlot, DateTime ngaysinh, string cmnd, bool gt, string ten,
        string lop, string sdt, List<string> mh)
        {
            this.MSSV = mssv;
            this.HoTenLot = hotenlot;
            this.NgaySinh = ngaysinh;
            this.CMND = cmnd;
            this.GioiTinh = gt;
            this.Ten = ten;
            this.Lop = lop;
            this.SDT = sdt;
            this.MonHoc = mh;
        }
    }
    
}
