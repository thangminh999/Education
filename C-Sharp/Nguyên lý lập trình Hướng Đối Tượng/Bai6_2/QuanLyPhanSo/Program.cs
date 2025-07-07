using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyPhanSo
{
    class Program
    {

        enum Menu
        {
            Thoat=10,
            Nhap=1,
            Xuat=2,
            TimMax,
            TimMau,
            DemSoAm,
        }

        static void Main(string[] args)
        {
            PhanSo kq = new PhanSo();
            MangPhanSo ds = new MangPhanSo();
            while (true)
            {
                Console.WriteLine("Nhap {0} de thoat ", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de thoat tu file ", (int)Menu.Nhap);
                Console.WriteLine("Nhap {0} de xuat tu file ", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de tim phan so lon nhat", (int)Menu.TimMax);
                Console.WriteLine("Nhap {0} de tim theo mau",(int)Menu.TimMau);
                Console.WriteLine("Nhap {0} de dem so am trong mang", (int)Menu.DemSoAm);
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch(menu)
                {
                    case Menu.Thoat:return;
                    case Menu.Nhap:
                        Console.Clear();
                        ds.NhapTuFile();
                        
                        break;
                    case Menu.Xuat:
                        Console.Clear();
                        ds.Xuat();
                        Console.ReadKey();       
                        break;
                    case Menu.TimMax:
                        Console.Clear();
                        kq=ds.TimMax();
                        Console.WriteLine("Phan so lon nhat la: ");
                        kq.Xuat();
                        Console.ReadKey();
                        break;
                    case Menu.TimMau:
                        Console.Clear();
                        Console.Write("Nhap x: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Phan so theo mau da cho la: ");
                      ds= ds.TimPhanSoCoMauLa(x);
                        ds.Xuat();
                        break;
                    case Menu.DemSoAm:
                        Console.Clear();
                        
                        
                        ds = ds.DemPhanSoAmTrongMang();
                        Console.WriteLine("So phan so am co trong mang la: ",ds);
                        break;

                }
            }
            Console.ReadLine();
            
        }
    }
}
