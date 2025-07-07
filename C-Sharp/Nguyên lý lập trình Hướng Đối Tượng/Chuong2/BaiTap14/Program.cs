using System;
using System.Collections;
using System.Collections.Generic;

namespace BaiTap14
{
    class Program
    {
        static void Main(string[] args)
        {
            // tinh diem trung binh
            
            double Diem1, Diem2, Diem3, Diem4, Diem5, Diem6, Diem7, Diem8;
            Console.WriteLine("Hay nhap diem thu 1: ");
            Diem1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap diem thu 2: ");
            Diem2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap diem thu 3: ");
            Diem3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap diem thu 4: ");
            Diem4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap diem thu 5: ");
            Diem5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap diem thu 6: ");
            Diem6 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap diem thu 7: ");
            Diem7 = double.Parse(Console.ReadLine());
            Console.WriteLine("Hay nhap diem thu 8: ");
            Diem8 = double.Parse(Console.ReadLine());
           
            double diemTB = (Diem1+Diem2+Diem3+Diem4+Diem5+Diem6+Diem7+Diem8) / 8;
            Console.WriteLine("\n=============================================");
           Console.WriteLine("Diem Trung Binh La: {0}",String.Format("{0:0.00}", diemTB));
            Console.ReadKey();
        }
    }
}
