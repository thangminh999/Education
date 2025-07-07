using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc2
{
    class HinhVuong : HinhHoc
    {
        public float canh;
     

        public HinhVuong()
        {

        }
        public HinhVuong(float canh)
        {
            this.canh = canh;
        }
        public override float TinhDT()
        {
            return (float)Math.Round(canh * canh, 0);
        }
        public override float TinhCV()
        {
            return (float)Math.Round(canh * 2, 0);
        }
        public override string ToString()
        {
            return "Hinh vuong ".PadRight(16)
                + ("canh: " + canh.ToString()).PadRight(25)
                + ("CV: " + TinhCV().ToString()).PadRight(25)
                + ("DT: " + TinhDT().ToString()).PadRight(15);
        }
      
    }
}

