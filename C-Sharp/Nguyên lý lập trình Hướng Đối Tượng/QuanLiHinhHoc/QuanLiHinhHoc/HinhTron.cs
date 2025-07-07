using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc
{
    class HinhTron:HinhHoc
    {
        public float banKinh;
        public HinhTron(float bk)
        {
            banKinh = bk;
        }
        public new float TinhDienTich()
        {
            return (float)Math.Round(Math.PI * banKinh * banKinh, 0);
        }
        public new float TinhChuVi()
        {
            return (float)Math.Round(2*Math.PI*banKinh , 0);
        }
        public override string ToString()
        {
            return "Hinh tron ban kinh " + banKinh + " dien tich " + TinhDienTich() + " chu vi " + TinhChuVi();
        }
    }
}
