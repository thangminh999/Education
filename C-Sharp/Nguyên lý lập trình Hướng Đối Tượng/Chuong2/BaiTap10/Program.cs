using System;

namespace BaiTap10
{
    class Program
    {
        static void Main(string[] args)
        {
            int MotGio = 60;
            int Phut;
            double Gio1;
            int Gio2;
            double Gio3;
            int Gio4;
            Console.Write(" moi ban nhap so phut :");
            Phut = int.Parse(Console.ReadLine());
            Console.Write("\n\n");
            Gio1 = (double)Phut / MotGio;//kieu thực
            Gio2 = Phut / MotGio;//đây là số giờ kiêu nguyên
            Gio3 = Gio1 - Gio2;// lấy phần dư thâp phân
            Gio3 = Gio3 * 60;// phần dư nhân cho 60 đổi thành phút
            Gio4 = (int)Gio3;// ép kiểu lấy phần nguyên
            Console.Write("{0} gio {1} phut",Gio2,Gio4);
            Console.ReadKey();
        }
    }
}
