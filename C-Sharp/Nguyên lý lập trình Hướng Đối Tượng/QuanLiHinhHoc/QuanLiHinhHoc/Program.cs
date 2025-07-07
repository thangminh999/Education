using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc
{
    class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTuFile = 1,
            Xuat = 2,
            TimHinhVuongCoDienTichLonNhat = 3,
            TimHinhVuongCoDienTichLaX = 4,
            TimHinhVuongCoChuViLaX = 5,
            TimHinhVuongCoDienTichNhoNhat = 6,
            TimHinhVuongCoChuViNhoNhat = 7,
            TimHinhVuongCoCanhNhoNhat = 8,
            TimHinhVuongCoCanhLonNhat = 9,
            TinhTongDienTichChuViHinhVuong = 10,
            DemSoLuongHinhVuong = 11,
            DemSoLuongHinhTron = 12,
            DemSoLuongHinhChuNhat = 13,
        }
        static void Main(string[] args)
        {
            int kq;
            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            int x;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Nhap {0} de thoat ", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de nhap tu file ", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de xuat ", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de tim hinh vuong co dien tich lon nhat ", (int)Menu.TimHinhVuongCoDienTichLonNhat);
                Console.WriteLine("Nhap {0} de tim hinh vuong co dien tich la x ", (int)Menu.TimHinhVuongCoDienTichLaX);
                Console.WriteLine("Nhap {0} de tim hinh vuong co chu vi la x ", (int)Menu.TimHinhVuongCoChuViLaX);
                Console.WriteLine("Nhap {0} de tim hinh vuong co dien tich nho nhat ", (int)Menu.TimHinhVuongCoDienTichNhoNhat);
                Console.WriteLine("Nhap {0} de tim hinh vuong co chu vi nho nhat ", (int)Menu.TimHinhVuongCoChuViNhoNhat);
                Console.WriteLine("Nhap {0} de tim hinh vuong co canh nho nhat ", (int)Menu.TimHinhVuongCoCanhNhoNhat);
                Console.WriteLine("Nhap {0} de tim hinh vuong co canh lon nhat ", (int)Menu.TimHinhVuongCoCanhLonNhat);
                Console.WriteLine("Nhap {0} de tinh tong dien tich chu vi hinh vuong  ", (int)Menu.TinhTongDienTichChuViHinhVuong);
                Console.WriteLine("Nhap {0} dem so luong hinh vuong", (int)Menu.DemSoLuongHinhVuong);
                Console.WriteLine("Nhap {0} dem so luong hinh tron", (int)Menu.DemSoLuongHinhTron);
                Console.WriteLine("Nhap {0} dem so luong hinh chu nhat", (int)Menu.DemSoLuongHinhChuNhat);
                Console.Write("Chon menu: ");
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case Menu.Thoat: return;
                    case Menu.NhapTuFile:
                        ds.NhapTuFile();
                        Console.WriteLine(ds.ToString());
                        break;
                    case Menu.Xuat:
                        Console.WriteLine(ds.ToString());
                        break;
                    case Menu.TimHinhVuongCoDienTichLonNhat:

                        Console.WriteLine("Hinh vuong co dien tich lon nhat la: " + ds.TimHinhVuongCoDienTichLonNhat());
                        break;
                    case Menu.TimHinhVuongCoDienTichLaX:
                        Console.Write("Nhap x: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dien tich can tim la: " + x);

                        Console.WriteLine(ds.TimHinhVuongCoDienTichLaX(x).ToString());
                        break;
                    case Menu.TimHinhVuongCoChuViLaX:
                        Console.Write("Nhap x: ");
                        x = int.Parse(Console.ReadLine());
                        Console.Write("Chu vi can tim la: " + x);

                        Console.WriteLine(ds.TimHinhVuongCoChuViLaX(x).ToString());
                        break;
                    case Menu.TimHinhVuongCoDienTichNhoNhat:

                        Console.WriteLine("Hinh vuong co dien tich nho nhat la: " + ds.TimHinhVuongCoDienTichNhoNhat());
                        break;
                    case Menu.TimHinhVuongCoChuViNhoNhat:

                        Console.WriteLine("Hinh vuong co chu vi nho nhat la: " + ds.TimHinhVuongCoChuViNhoNhat());
                        break;
                    case Menu.TimHinhVuongCoCanhNhoNhat:

                        Console.WriteLine("Hinh vuong co chu vi nho nhat la: " + ds.TimHinhVuongCoCanhNhoNhat());
                        break;
                    case Menu.TimHinhVuongCoCanhLonNhat:

                        Console.WriteLine("Hinh vuong co chu vi nho nhat la: " + ds.TimHinhVuongCoCanhLonNhat());
                        break;
                    case Menu.TinhTongDienTichChuViHinhVuong:
                        Console.Write("Tong Dien Tich Hinh vuong la: " + ds.TinhTongDienTichHinhVuong());
                        Console.Write(" va Tong Chu vi Hinh vuong la: " + ds.TinhTongChuViHinhVuong());
                        break;
                    case Menu.DemSoLuongHinhVuong:
                        Console.Write("So luong hinh vuong la: " + ds.DemSoLuongHinhVuong());
                        Console.WriteLine(ds.XuatHinhVuong());
                        break;
                    case Menu.DemSoLuongHinhTron:
                        Console.Write("So luong hinh tron la: " + ds.DemSoLuongHinhTron());
                        Console.WriteLine(ds.XuatHinhTron());
                        break;
                    case Menu.DemSoLuongHinhChuNhat:
                        Console.Write("So luong hinh tron la: " + ds.DemSoLuongHinhChuNhat());
                        Console.WriteLine(ds.XuatHinhChuNhat());
                        break;
                }
                Console.ReadKey();
            }


        }
    }
}
