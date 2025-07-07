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

            DemSDTTheoThueBao = 3,
            DemSoThueBaoXuatHienNhieuNhat = 4,
            TimSoThueBaoXuatHienNhieuNhat = 5,
            TimSoThueBaoXuatHienItNhat = 6,
            TimSoThueBaoXuatHienNhieuNhatTheoDC = 7,
            TimThueBaoSoHuuSDTItNhat = 8,
        }
        static void Main(string[] args)
        {
            DanhBa a = new DanhBa();
            List<string> kq = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Nhap {0} de thoat ", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de nhap tu file ", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de xuat ", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de dem sdt theo cmnd ", (int)Menu.DemSDTTheoThueBao);
                Console.WriteLine("Nhap {0} de dem sdt xuat hien nhieu nhat theo cmnd ", (int)Menu.DemSoThueBaoXuatHienNhieuNhat);
                Console.WriteLine("Nhap {0} de tim sdt xuat hien nhieu nhat ", (int)Menu.TimSoThueBaoXuatHienNhieuNhat);
                Console.WriteLine("Nhap {0} de tim thanh pho co sdt it nhat", (int)Menu.TimSoThueBaoXuatHienItNhat);
                Console.WriteLine("Nhap {0} de tim thanh pho co sdt nhieu nhat theo dia chi", (int)Menu.TimSoThueBaoXuatHienNhieuNhatTheoDC);
                Console.WriteLine("Nhap {0} de tim thue bao co sdt it nhat", (int)Menu.TimThueBaoSoHuuSDTItNhat);
               Menu menu = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case Menu.Thoat: return;
                    case Menu.NhapTuFile:
                        a.NhapTuFile();
                        a.Xuat();
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
                        a.TimThueBaoCoNhieuSDT();
                        break;
                    case Menu.TimSoThueBaoXuatHienItNhat:
                        kq = a.TimThueBaoCoSDTItNhatTheoDiaChi();
                        Console.Write("Thanh pho it thue bao nhat la: ");
                        foreach (string item in kq)
                        {

                            Console.Write("\n" + item);


                        }
                        break;
                    case Menu.TimSoThueBaoXuatHienNhieuNhatTheoDC:
                        kq = a.TimThueBaoCoSDTNhieuNhatTheoDC();
                        Console.Write("Thanh pho nhieu thue bao nhat la: ");
                        foreach (string item in kq)
                        {

                            Console.Write("\n" + item);


                        }
                        break;
                    case Menu.TimThueBaoSoHuuSDTItNhat:
                        kq = a.TimThueBaoSoHuuSDTItNhat();
                        Console.WriteLine("Thue bao so huu it sdt nhat la: ");
                        foreach (string item in kq)
                        {
                            Console.WriteLine("\n" + item);
                        }
                        break;

                }

                Console.ReadKey();
            }

        }
    }
}
