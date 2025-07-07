using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Demo
{
    internal class SinhVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public string Email {get; set;}
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; }
        public string SDT {get; set;}

        public SinhVien()
        {
            
        }

        public SinhVien(string ms, string ht, DateTime ngay,
        string dc, string lop, string hinh, bool gt,string sdt,string mail, List<string> cn)
        {
            this.MaSo = ms;
            this.HoTen = ht;
            this.Email = mail;
            this.DiaChi = dc;
            this.Lop = lop;
            this.NgaySinh = ngay;
            this.Hinh = hinh;
            this.GioiTinh = gt;
            this.SDT = SDT;
        }
    }
}

