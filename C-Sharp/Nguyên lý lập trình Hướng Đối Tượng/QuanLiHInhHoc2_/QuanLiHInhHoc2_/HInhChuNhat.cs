using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc2
{
    class HinhChuNhat : HinhHoc
    {
        public float dai;
        public  float rong;
        public HinhChuNhat()
        {
        }
        public HinhChuNhat(float dai, float rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public override float TinhDT()
        {
            return (float)Math.Round(dai * rong, 0);
        }
        public override float TinhCV()
        {
            return (float)Math.Round((dai + rong) * 2, 0);
        }
        public override string ToString()
        {
            return "HCN ".PadRight(15) +
                (" Dài: " + dai.ToString() +
                " rộng: " + rong.ToString()).PadRight(26)
                + ("CV: " + TinhCV().ToString()).PadRight(24) +
                (" DT: " + TinhDT().ToString());
        }
       
    }
}
