using System;

namespace Baitap7
{
    class Program
    {
        private const int namToi = 4;

        static void Main(string[] args)
        {

            double luongNhanVien1 = 3000000;
            double luongNhanVien2 = 6000000;
            double luongNhanVien3 = 5000000;
            Console.WriteLine("luong nhan vien 1 ban dau la {0}", luongNhanVien1);
            Console.WriteLine("luong nhan vien  2 ban dau la {0}", luongNhanVien2);
            Console.WriteLine("luong nhan vien 3 ban dau la {0}", luongNhanVien3);
            Console.WriteLine("\n\n");
            Console.WriteLine("next year’s salary for each employee.");
            Console.WriteLine("Muc luong nhan Vien thu 1  nam toi là :{0}", luongNhanVien1 / 100 * namToi+luongNhanVien1);
            Console.WriteLine("Muc luong nhan Vien thu 2 nam toi là :{0}", luongNhanVien2 / 100 * namToi + luongNhanVien2);
            Console.WriteLine("Muc luong nhan Vien thu 2  nam toi là :{0}", luongNhanVien3 / 100 * namToi + luongNhanVien3);
            Console.ReadKey();
        }
    }
}
