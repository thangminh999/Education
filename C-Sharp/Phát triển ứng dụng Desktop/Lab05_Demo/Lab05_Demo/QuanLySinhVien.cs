using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Demo
{
    class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }

        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }

        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }


    }
}
