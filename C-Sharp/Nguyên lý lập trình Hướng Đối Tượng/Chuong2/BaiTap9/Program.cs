using System;

namespace BaiTap9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int OneHour = 150;
            const int Dam = 2;
            int SoGio,DiChuyen;
            Console.WriteLine("Moi ban nhap so gio : ");
            SoGio= int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap so dam : ");
            DiChuyen = int.Parse(Console.ReadLine());
            Console.Write("\n\n");
            Console.WriteLine("tong chi Phi {0}",(SoGio*OneHour)+(DiChuyen*Dam)+200);
            Console.ReadKey();
        }
    }
}
