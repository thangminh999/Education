using System;

namespace BaiTap13
{
    class Program
    {
        static void Main(string[] args)
        {
            int nhapTien=0;
            Console.Write(" moi ban nhap so tien muon chuyen doi : ");
            nhapTien = int.Parse(Console.ReadLine());
            double doiThanh20 = nhapTien / 20;
            int doiThanhSoNuyen = nhapTien / 20;// day la gan cho may lan 20 (twenties)
            int troLai = nhapTien - (doiThanhSoNuyen * 20);// 
            int troLaiOne = troLai / 10;// day la gan cho may lan 10 (Ten)
            int lanNua = troLai - (troLaiOne * 10);
            int quiDoi5 = lanNua / 5;// day la phep gan cho 5 (fives)
            int Next = lanNua - (quiDoi5 * 5);
            Console.WriteLine(" co {0}  twenties va {1} Ten va {2} Fives va {3} One", doiThanhSoNuyen, troLaiOne, quiDoi5, Next);
            Console.ReadKey();


        }
    }
}
