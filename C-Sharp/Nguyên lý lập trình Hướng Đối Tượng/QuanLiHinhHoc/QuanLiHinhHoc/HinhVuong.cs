using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc
{
    class HinhVuong:HinhHoc
    {
        public float canh;
        public HinhVuong()
        {

        }
        public HinhVuong(float c)
        {
            canh = c;
        }
        public new float TinhDienTich()
        {
            return (float)Math.Round(canh * canh, 0);
        }
        public new float TinhChuVi()
        {
            return (float)Math.Round(canh * 4, 0);
        }
        public override string ToString()
        {
            return "Hinh vuong canh " + canh + " dien tich " + TinhDienTich()+
           " chu vi " + TinhChuVi();
        }
      

    }
}
