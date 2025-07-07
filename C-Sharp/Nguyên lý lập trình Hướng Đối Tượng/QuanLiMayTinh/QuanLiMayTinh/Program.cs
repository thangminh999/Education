using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMayTinh
{
    class Program
    {
        enum Menu
        {
            Exit,
            NhapTuFile,
            Xuat,
            TimMayTinhCoGiaCaoNhat,
            TimMayTinhCoGiaThapNhat,
            DemThietBiTheoHang,
            TimDanhSachHang,
            TimHangXuatHienNhieuNhat,
            TimGiaCPUMinMax,
            TimGiaRamMinMax,
            TimHangCPUMinMax,
            TimHangRamMinMax,
            Xoa,
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachMayTinh ds = new DanhSachMayTinh();
            List<string> mt = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Nhập {0} để Thoát", (int)Menu.Exit);
                Console.WriteLine("Nhập {0} để NhậpTuFile", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhập {0} để Xuat", (int)Menu.Xuat);
                Console.WriteLine("Nhập {0} để tìm máy tính có giá cao nhất", (int)Menu.TimMayTinhCoGiaCaoNhat);
                Console.WriteLine("Nhập {0} để tìm máy tính có giá thấp nhất", (int)Menu.TimMayTinhCoGiaThapNhat);
                Console.WriteLine("Nhập {0} để đếm thiết bị theo hãng", (int)Menu.DemThietBiTheoHang);
                Console.WriteLine("Nhập {0} để tìm danh sách hãng", (int)Menu.TimDanhSachHang);
                Console.WriteLine("Nhập {0} để tìm danh sách hãng xuất hiện nhiều nhất", (int)Menu.TimHangXuatHienNhieuNhat);
                Console.WriteLine("Nhập {0} để tìm giá CPU rẻ nhất,mắc nhất", (int)Menu.TimGiaCPUMinMax);
                Console.WriteLine("Nhập {0} để tìm giá Ram rẻ nhất,mắc nhất", (int)Menu.TimGiaRamMinMax);
                Console.WriteLine("Nhập {0} để tìm hãng có nhiều,ít CPU nhất", (int)Menu.TimHangCPUMinMax);
                Console.WriteLine("Nhập {0} để tìm hãng có nhiều,ít Ram nhất", (int)Menu.TimHangRamMinMax);
                Console.WriteLine("Nhập {0} để xóa CPU của hãng ", (int)Menu.Xoa);
                Console.WriteLine("Nhập để chon: " );
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case Menu.Exit: return;
                    case Menu.NhapTuFile:
                        ds.NhapTuFile();
                        Console.WriteLine("Danh sách máy tính là ");
                        Console.WriteLine(ds);
                        break;
                    case Menu.Xuat:
                        Console.WriteLine("Danh sách máy tính là ");
                        Console.WriteLine(ds);
                        break;
                    case Menu.TimMayTinhCoGiaCaoNhat:
                        Console.WriteLine("\n---------------------\nDanh sách máy tính có giá cao nhất là ");
                        Console.WriteLine(ds.TimGiaMaxTrongDanhSach());
                        break;
                    case Menu.TimMayTinhCoGiaThapNhat:
                        Console.WriteLine("\n---------------------\nDanh sách máy tính có giá thấp nhất là ");
                        Console.WriteLine(ds.TimGiaMinTrongDanhSach());
                        break;
                    case Menu.DemThietBiTheoHang:
                        Console.Write("Nhập tên hãng: ");
                        string hang = Console.ReadLine();
                        Console.WriteLine("Đếm hãng "+ hang +": "+ ds.DemThietBiTheoHang(hang));
                        break;
                    case Menu.TimDanhSachHang:
                      
                        Console.WriteLine("Danh sách các hãng không trùng nhau là ");
                        foreach (string s in ds.TimDanhSachHang())
                            Console.WriteLine(s);
                        break;
                    case Menu.TimHangXuatHienNhieuNhat:
                        Console.WriteLine("Hãng xuất hiện nhiều nhất là ");
                        foreach (string s in ds.TimHangXuatHienNhieuNhat())
                            Console.WriteLine(s + " số lần " + ds.DemThietBiTheoHang(s));
                        break;
                    case Menu.TimGiaCPUMinMax:                    
                        Console.WriteLine("Hãng co gia CPU re nhat la: \n" + ds.TimCPUGiaMin());
                        Console.WriteLine("Hãng co gia CPU cao nhat la: \n" + ds.TimCPUGiaMax());
                        break;
                    case Menu.TimGiaRamMinMax:
                        Console.WriteLine("Hãng co gia Ram re nhat la: \n" + ds.TimRamGiaMin());
                        Console.WriteLine("Hãng co gia Ram cao nhat la: \n" + ds.TimRamGiaMax());
                        break;
                    case Menu.TimHangCPUMinMax:
                        // Hàm list phải có foreach để xuất ra
                        Console.WriteLine("Hãng có nhiều CPU sử dụng nhất là: " );
                        foreach (var item in ds.CPUXHMaxTheoHang())
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\nHãng có ít CPU sử dụng nhất là: " );
                        foreach(var item in ds.CPUXHMinTheoHang())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case Menu.TimHangRamMinMax:
                        Console.WriteLine("Hãng có nhiều RAM sử dụng nhất là: ");
                        foreach (var item in ds.TimRamXHMaxTheoHang())
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Hãng có ít RAM sử dụng nhất là: ");
                        foreach (var item in ds.TimRamXHMinTheoHang())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case Menu.Xoa:
                        Console.WriteLine("Nhập hãng CPU trong danh sách: ");
                        string CPU = Console.ReadLine();
                        Console.WriteLine("Xóa CPU của hãng: "+CPU);
                        ds.ToString();
                        ds.XoaCPUTheoHang(CPU);
                        Console.Write("Danh sách sau khi đã xóa là: "+ds.ToString());
                        break;
                    default:
                        Console.WriteLine("ERORR,please write again");
                        break;

                       
                        
                }
                Console.ReadKey();
            }
        }
    }
}
