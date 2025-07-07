using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa_
{
    enum GioiTinh
    {
        Nam,
        Nu
    }
    class ThueBao
    {
        public string soCMND;
        public string hoTen;
        public string diaChi;
        public GioiTinh gioiTinh;
        public DateTime ngaySinh;
        public string sDT;
        public ThueBao()
        {

        }
        public ThueBao(string soCMND, string hoTen, string dicChi, GioiTinh gioiTinh, DateTime ngaySinh, string sDT)
        {
            this.soCMND = soCMND;
            this.hoTen = hoTen;
            this.diaChi = dicChi;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.sDT = sDT;
        }
        public ThueBao(string line)
        {
            string[] s = line.Split(' ');
            this.soCMND=s[0].Trim();
            this.hoTen = s[1].Trim();
            this.diaChi = s[2].Trim();
            this.gioiTinh = s[3].Trim() == "Nam"? GioiTinh.Nam : GioiTinh.Nu;
            this.ngaySinh = DateTime.Parse(s[4]);
            this.sDT = s[5];
        }
        public void Xuat()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            string s = "{0} {1} {2} {3} {4} {5} \r\n";
            return string.Format(s, soCMND.PadRight(7), hoTen.PadRight(15), diaChi.PadRight(20), ngaySinh.ToShortDateString().PadRight(11), sDT.PadRight(10), gioiTinh);
            //return base.ToString();
        }

    }
}
