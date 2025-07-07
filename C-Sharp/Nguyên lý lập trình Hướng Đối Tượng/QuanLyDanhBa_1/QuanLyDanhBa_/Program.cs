using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyDanhBa_
{
    class Program
    {
        enum Menu
        {
            Thoat = 10,
            NhapTuFile = 1,
            Xuat = 2,
           
            DemSDTTheoThueBao=3,
            DemSoThueBaoXuatHienNhieuNhat=4,
            TimSoThueBaoXuatHienNhieuNhat=5,
        }
        static void Main(string[] args)
        {
            DanhBa a = new DanhBa();
          
            while (true)
            {
               
                Console.WriteLine("Nhap {0} de thoat ", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de nhap tu file ", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de xuat ", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de dem sdt theo cmnd ", (int)Menu.DemSDTTheoThueBao);
                Console.WriteLine("Nhap {0} de dem sdt xuat hien nhieu nhat theo cmnd ", (int)Menu.DemSoThueBaoXuatHienNhieuNhat);
                Console.WriteLine("Nhap {0} de tim sdt xuat hien nhieu nhat ", (int)Menu.TimSoThueBaoXuatHienNhieuNhat);
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case Menu.Thoat: return;
                    case Menu.NhapTuFile:
                        a.NhapTuFile();
                        break;
                    case Menu.Xuat:
                       Console.WriteLine("File vua nhap la: ");
                        a.Xuat();
                        break;
                    case Menu.DemSDTTheoThueBao:
                        Console.Write("Nhap cmnd can dem: ");
                        string cmnd = Console.ReadLine();
                        Console.Write("Ket qua la:{0} ", a.DemSoDTTheoThueBao(cmnd));
                        
                        break;
                    case Menu.DemSoThueBaoXuatHienNhieuNhat:
                        Console.Write("Ket qua la: {0}", a.DemThueBaoXuatHienNhieuNhat());
                        break;
                    case Menu.TimSoThueBaoXuatHienNhieuNhat:

                        Console.Write("Ket qua la: {0}", a.TimThueBaoCoNhieuSDT());
                        break;

                }

                Console.ReadKey();
            }
                
        }
    }
}
