using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMayTinh
{
    class OCung :CPU
    { 
        public OCung()
        {
        }
        public OCung(string hang, float gia)
        {
            HangSX = hang;
            Gia = gia;
        }
        public OCung(string line)
        {
            string[] s = line.Split(',');
            HangSX = s[1];
            Gia = float.Parse(s[2]);
        }
        public override string ToString()
        {
            return "Ổ cứng hãng " + HangSX + " có giá là " + Gia;
        }
    }
}
