using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc
{
    class HinhChuNhat:HinhHoc
    {
        public float dai;
        public float rong;
        public HinhChuNhat()
        {

        }
        public HinhChuNhat(float d,float r)
        {
            dai = d;
            rong = r;
        }
        public new float TinhDienTich()
        {
            return (float)Math.Round(dai * rong, 0);
        }
        public new float TinhChuVi()
        {
            return (float)Math.Round((dai + rong)/2, 0);
        }
        public override string ToString()
        {
            return "Hinh chu nhat rong =  " + rong + ", dai = " + dai + "  dien tich " + TinhDienTich() +" chu vi " + TinhChuVi();
        }
    }
}
