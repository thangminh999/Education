using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMayTinh
{
    class Ram : CPU
    { 
        public Ram()
        {

        }
        public Ram(string line):base(line)
        {

        }
        public override string ToString()
        {
            return "Ram của hãng " + HangSX + " có giá là: " + Gia;
        }
    }
}
