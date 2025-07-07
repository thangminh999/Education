using System;

namespace BaiTap8
{
    class Program
    {
        private const int namToi = 4;
        static void Main(string[] args)
        {
            double luongNhanVien1; 
            double luongNhanVien2; 
            double luongNhanVien3;
          
            Console.Write(" Moi ban nhap luong nhan vien thu 1 : ");
            luongNhanVien1 = double.Parse(Console.ReadLine());
            Console.Write(" Moi ban nhap luong nhan vien thu 2 : ");
            luongNhanVien2 = double.Parse(Console.ReadLine());
            Console.Write(" Moi ban nhap luong nhan vien thu 3 : ");
            luongNhanVien3 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine("luong nhan vien 1 ban dau la {0}", luongNhanVien1);
            Console.WriteLine("luong nhan vien  2 ban dau la {0}", luongNhanVien2);
            Console.WriteLine("luong nhan vien 3 ban dau la {0}", luongNhanVien3);
            Console.WriteLine("\n\n");

            Console.WriteLine("next year’s salary for each employee.");
            Console.WriteLine("Muc luong nhan Vien thu 1  nam toi là :{0}", luongNhanVien1 / 100 * namToi + luongNhanVien1);
            Console.WriteLine("Muc luong nhan Vien thu 2 nam toi là :{0}", luongNhanVien2 / 100 * namToi + luongNhanVien2);
            Console.WriteLine("Muc luong nhan Vien thu 2  nam toi là :{0}", luongNhanVien3 / 100 * namToi + luongNhanVien3);
            Console.ReadKey();
        }
    }
}
