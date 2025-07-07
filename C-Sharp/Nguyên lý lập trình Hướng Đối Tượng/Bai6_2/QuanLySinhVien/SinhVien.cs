using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVien
    {
        public int maSV;
        public int ngay;
        public int thang;
        public int nam;
       
        public string hoTen;
        
        public string queQuan;
        public void Nhap()
        {
            Console.Write("Nhap ma SV: ");
            maSV = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay sinh: ");
            ngay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang sinh: ");
            thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam sinh: ");
            nam = int.Parse(Console.ReadLine());
            
            Console.Write("Nhap ho va ten : ");
            hoTen=Console.ReadLine();
           
          
            Console.Write("Nhap que quan: ");
            queQuan = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("maSV\t\tngay\tthang\tnam\tHoTen\t\t\tQueQuan");
            Console.WriteLine("{0}\t\t{1}\t{2}\t{3}\t{4}\t\t{5} ", maSV, ngay,thang,nam, hoTen, queQuan);
        }

    }
}
