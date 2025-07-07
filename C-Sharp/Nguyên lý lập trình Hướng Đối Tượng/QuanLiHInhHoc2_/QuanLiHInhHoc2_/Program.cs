using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc2
{
    class Program
    {
        enum Menu
        {
            Thoat = 0,
            Nhap = 1,
            Xuat = 2,
            TimDienTichLonNhatCuaDanhSach=34,
            XoaHinhCoDienTichLonNhatTrongDanhSach=35,
            XoaTaiViTri=36,
            //HINH VUONG
                // dem
                DemSoLuongHinhVuong=37,
                //Tinh Tong
            TinhTongDienTichHinhVuong=30,
                //cạnh
            TimHinhVuongCoCanhLaX=29,
                //dien tich
            TimDienTichHinhVuongLonNhat = 3,
            TimDienTichHinhVuongNhoNhat = 6,            
            TimHinhVuongCoDienTichLaX = 16,
                //chu vi
            TimChuViHinhVuongLonNhat = 9,
            TimHinhVuongCoChuViLaX = 15,
            TimChuViHinhVuongNhoNhat = 12,
                //sap xep
              
            //HINH CHU NHAT
                // Tinh tong
           TinhTongDienTichHinhChuNhat=31,
                //canh
            TimHinhChuNhatCoCanhLaX=27,
                //dien tich
            TimDienTichHinhChuNhatLonNhat = 4,
            TimDienTichHinhChuNhatNhoNhat = 7,
            TimHinhChuNhatCoDienTichLaX = 18,
                //chu vi
            TimChuViHinhChuNhatLonNhat = 10,
            TimChuViHinhChuNhatNhoNhat = 13,
            TimHinhChuNhatCoChuViLaX = 17,
                //ham sap xep
            SapXepDienTichTangDanHinhChuNhat = 22,
            SapXepDienTichGiamDanHinhChuNhat = 21,
            SapXepChuViTangDanHCN = 23,
            //HINH TRON
                //canh
            TimHinhTronCoBanKinhLaX=28,
                //dien tich
            TimDienTichHinhTronLonNhat = 5,
            TimDienTichHinhTronNhoNhat = 8,
            TimHinhTronCoDienTichLaX = 20,
                //chu vi
            TimChuViHinhTronLonNhat = 11,     
            TimChuViHinhTronNhoNhat = 14,  
            TimHinhTronCoChuViLaX = 19,
                //ham sap xep
            SapXepDienTichTangDanHinhTron = 24,// chua co ham
            SapXepDienTichGiamDanHinhTron = 25,// chua co ham
            SapXepChuViTangDanHinhTron =26,// chua co ham
                // TinhTong
            TinhTongDienTichHinhTron=32,
                //Xoa 
                XoaDienTichLonNhat=33,
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachHinhHoc hh = new DanhSachHinhHoc();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Nhập {0} để thoát", (int)Menu.Thoat);    //0
                Console.WriteLine("Nhập {0} để nhap", (int)Menu.Nhap);      //1
                Console.WriteLine("Nhập {0} để xuat", (int)Menu.Xuat);      //2
               
                Console.WriteLine("Nhập {0} để tim dien tich hinh vuong lon nhat", (int)Menu.TimDienTichHinhVuongLonNhat);  //3
                Console.WriteLine("Nhập {0} để tim dien tich hinh chu nhat lon nhat", (int)Menu.TimDienTichHinhChuNhatLonNhat); //4
                Console.WriteLine("Nhập {0} để tim dien tich hinh tron lon nhat", (int)Menu.TimDienTichHinhTronLonNhat);    //5
            
                
                Console.WriteLine("Nhập {0} để tim dien tich hinh vuong nho nhat", (int)Menu.TimDienTichHinhVuongNhoNhat);  //6
                Console.WriteLine("Nhập {0} để tim dien tich hinh chu nhat nho nhat", (int)Menu.TimDienTichHinhChuNhatNhoNhat); //7
                Console.WriteLine("Nhập {0} để tim dien tich hinh tron nho nhat", (int)Menu.TimDienTichHinhTronNhoNhat); //8
             
                Console.WriteLine("Nhập {0} để tim chu vi hinh vuong lon nhat", (int)Menu.TimChuViHinhVuongLonNhat); //9
                Console.WriteLine("Nhập {0} để tim chu vi hinh chu nhat lon nhat", (int)Menu.TimChuViHinhChuNhatLonNhat); //10
                Console.WriteLine("Nhập {0} để tim chu vi hinh tron lon nhat", (int)Menu.TimChuViHinhTronLonNhat); //11
                Console.WriteLine("Nhập {0} để tim chu vi hinh vuong nho nhat", (int)Menu.TimChuViHinhVuongNhoNhat); //12
                Console.WriteLine("Nhập {0} để tim chu vi hinh chu nhat nho nhat", (int)Menu.TimChuViHinhChuNhatNhoNhat); //13
                Console.WriteLine("Nhập {0} để tim chu vi hinh tron nho nhat", (int)Menu.TimChuViHinhTronNhoNhat); //14
                Console.WriteLine("Nhập {0} để tim hinh vuong co chu vi la x", (int)Menu.TimHinhVuongCoChuViLaX);   //15
                Console.WriteLine("Nhập {0} để tim hinh vuong co dien tich la x", (int)Menu.TimHinhVuongCoDienTichLaX); //16
                Console.WriteLine("Nhập {0} để tim hinh chu nhat co chu vi la x", (int)Menu.TimHinhChuNhatCoChuViLaX);  //17
                Console.WriteLine("Nhập {0} để tim hinh chu nhat co dien tich la x", (int)Menu.TimHinhChuNhatCoDienTichLaX); //18
                Console.WriteLine("Nhập {0} để tim hinh tron co chu vi la x", (int)Menu.TimHinhTronCoChuViLaX); //19
                Console.WriteLine("Nhập {0} để tim hinh tron co dien tich la x", (int)Menu.TimHinhTronCoDienTichLaX);   //20
                Console.WriteLine("Nhập {0} để sap xep dien tich giam dan theo hinh chu nhat", (int)Menu.SapXepDienTichGiamDanHinhChuNhat); //21
                Console.WriteLine("Nhập {0} để sap xep dien tich tang dan theo hinh chu nhat", (int)Menu.SapXepDienTichTangDanHinhChuNhat); //22
                Console.WriteLine("Nhập {0} để sap xep chu vi tang dan theo hinh chu nhat", (int)Menu.SapXepChuViTangDanHCN);   //23
                Console.WriteLine("Nhập {0} để tim hinh chu nhat co canh la x", (int)Menu.TimHinhChuNhatCoCanhLaX); //27
                Console.WriteLine("Nhập {0} để tim hinh tron co canh la x", (int)Menu.TimHinhTronCoBanKinhLaX); //28
                Console.WriteLine("Nhập {0} để tim hinh vuong co canh la x", (int)Menu.TimHinhVuongCoCanhLaX); //29
                Console.WriteLine("Nhập {0} để tinh tong dien tich hinh vuong", (int)Menu.TinhTongDienTichHinhVuong); //30
                Console.WriteLine("Nhập {0} để tinh tong dien tich hinh chu nhat", (int)Menu.TinhTongDienTichHinhChuNhat);
                Console.WriteLine("Nhập {0} để tinh tong dien tich hinh tron", (int)Menu.TinhTongDienTichHinhTron);
                Console.WriteLine("Nhập {0} để tinh xoa dien tich hinh tron lon nhat", (int)Menu.XoaDienTichLonNhat);
                Console.WriteLine("Nhập {0} để xoa dien tich hinh lon nhat trong danh sach", (int)Menu.XoaHinhCoDienTichLonNhatTrongDanhSach);
                Console.WriteLine("Nhập {0} để tinh xoa tai vi tri", (int)Menu.XoaTaiViTri);
                Console.WriteLine("Nhập {0} để dem so luong hinh vuong", (int)Menu.DemSoLuongHinhVuong);
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    //case 0
                    case  Menu.Thoat: return; 
                    //case 1
                    case Menu.Nhap:
                        hh.NhapTuFile();
                        Console.Write(hh.ToString());
                        break;
                    //case 2
                    case Menu.Xuat:
                        Console.Write(hh.ToString());
                        break;
                    //case 3
                    case Menu.TimDienTichHinhVuongLonNhat:
                        Console.WriteLine("Danh sach hinh vuong la: ");
                        Console.WriteLine(hh.TimHinh<HinhVuong>()+"\n");
                        Console.WriteLine("Hinh vuong co dien tich lon nhat la: ");
                        Console.WriteLine(hh.TimDienTichLonNhat2<HinhVuong>());
                        break;
                    //case 4
                    case Menu.TimDienTichHinhChuNhatLonNhat:
                        Console.WriteLine("Danh sach hinh chu nhat la: ");
                        Console.WriteLine(hh.TimHinh<HinhChuNhat>() + "\n");
                        Console.WriteLine("Hinh chu nhat co dien tich lon nhat la: ");

                        Console.WriteLine(hh.TimDienTichLonNhat2<HinhChuNhat>());
                        break;
                    //case 5
                    case Menu.TimDienTichHinhTronLonNhat:
                        Console.WriteLine("Danh sach hinh tron la: ");
                        Console.WriteLine(hh.TimHinh<HinhTron>() + "\n");
                        Console.WriteLine("Hinh tron co dien tich lon nhat la: ");
                        Console.WriteLine(hh.TimDienTichLonNhat2<HinhTron>());
                        break;
                    //case 6
                    case Menu.TimDienTichHinhVuongNhoNhat:
                        Console.WriteLine("Danh sach hinh vuong la: ");
                        Console.WriteLine(hh.TimHinh<HinhVuong>() + "\n");
                        Console.WriteLine("Hinh vuong co dien tich nho nhat la: ");
                        Console.WriteLine(hh.TimDienTichNhoNhat2<HinhVuong>());
                        break;
                    //case 7
                    case Menu.TimDienTichHinhTronNhoNhat:
                        Console.WriteLine("Danh sach hinh tron la: ");
                        Console.WriteLine(hh.TimHinh<HinhTron>() + "\n");
                        Console.WriteLine("Hinh tron co dien tich nho nhat la: ");
                        Console.WriteLine(hh.TimDienTichNhoNhat2<HinhTron>());
                        break;
                    //case 8
                    case Menu.TimChuViHinhVuongLonNhat:
                        Console.WriteLine("Danh sach hinh vuong la: ");
                        Console.WriteLine(hh.TimHinh<HinhVuong>() + "\n");
                        Console.WriteLine("Hinh vuong co dien tich lon nhat la: ");
                        Console.WriteLine(hh.TimChuViLonNhat2<HinhVuong>());
                        break;
                    //case 9
                    case Menu.TimChuViHinhChuNhatLonNhat:
                        Console.WriteLine("Danh sach hinh chu nhat la: ");
                        Console.WriteLine(hh.TimHinh<HinhChuNhat>() + "\n");
                        Console.WriteLine("Hinh chu nhat co dien tich lon nhat la: ");

                        Console.WriteLine(hh.TimDienTichLonNhat2<HinhChuNhat>());
                        break;
                    //case 10
                    case Menu.TimChuViHinhTronLonNhat:
                        Console.WriteLine("Danh sach hinh tron la: ");
                        Console.WriteLine(hh.TimHinh<HinhTron>() + "\n");
                        Console.WriteLine("Hinh tron co dien tich lon nhat la: ");
                        Console.WriteLine(hh.TimChuViLonNhat2<HinhTron>());
                        break;
                    //case 11
                    case Menu.TimDienTichHinhChuNhatNhoNhat:
                        Console.WriteLine("Danh sach hinh chu nhat la: ");
                        Console.WriteLine(hh.TimHinh<HinhChuNhat>() + "\n");
                        Console.WriteLine("Hinh chu nhat co dien tich nho nhat la: ");
                        Console.WriteLine(hh.TimDienTichNhoNhat2<HinhChuNhat>());
                        break;
                    //case 12
                    case Menu.TimChuViHinhVuongNhoNhat:
                        Console.WriteLine("Danh sach hinh vuong la: ");
                        Console.WriteLine(hh.TimHinh<HinhVuong>() + "\n");
                        Console.WriteLine("Hinh vuong co dien tich nho nhat la: ");
                        Console.WriteLine(hh.TimChuViNhoNhat2<HinhVuong>());
                        break;
                    //case 13
                    case Menu.TimChuViHinhChuNhatNhoNhat:
                        Console.WriteLine("Danh sach hinh chu nhat la: ");
                        Console.WriteLine(hh.TimHinh<HinhChuNhat>() + "\n");
                        Console.WriteLine("Hinh chu nhat co dien tich nho nhat la: ");
                        Console.WriteLine(hh.TimChuViNhoNhat2<HinhChuNhat>());
                        break;
                    //case 14
                    case Menu.TimChuViHinhTronNhoNhat:
                        Console.WriteLine("Danh sach hinh tron la: ");
                        Console.WriteLine(hh.TimHinh<HinhTron>() + "\n");
                        Console.WriteLine("Hinh tron co dien tich nho nhat la: ");
                        Console.WriteLine(hh.TimChuViNhoNhat2<HinhTron>());
                        break;
                    //case 15
                    case Menu.TimHinhVuongCoChuViLaX:
                       
                        Console.WriteLine("Danh sach hinh vuong: ");
                        Console.WriteLine(hh.TimHinh<HinhVuong>() + "\n");
                        Console.Write("Nhap x  de tim chu vi:: ");
                        float x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh vuong can tim la: ");
                        Console.WriteLine(hh.TimHinhCoChuViLaX<HinhVuong>(x));
                        break;
                    //case 16
                    case Menu.TimHinhVuongCoDienTichLaX:

                        Console.WriteLine("Danh sach hinh vuong: ");
                        Console.WriteLine(hh.TimHinh<HinhVuong>() + "\n");
                        Console.Write("Nhap x de tim dien tich:: ");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh vuong can tim la: ");
                        Console.WriteLine(hh.TimHinhCoDienTichLaX<HinhVuong>(x));
                        break;
                    //case 17
                    case Menu.TimHinhChuNhatCoChuViLaX:

                        Console.WriteLine("Danh sach hinh chu nhat: ");
                        Console.WriteLine(hh.TimHinh<HinhChuNhat>() + "\n");
                        Console.Write("Nhap x de tim chu vi: ");
                         x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh chu nhat can tim la: ");
                        Console.WriteLine(hh.TimHinhCoChuViLaX<HinhChuNhat>(x));
                        break;
                    //case 18
                    case Menu.TimHinhChuNhatCoDienTichLaX:

                        Console.WriteLine("Danh sach hinh chu nhat: ");
                        Console.WriteLine(hh.TimHinh<HinhChuNhat>() + "\n");
                        Console.Write("Nhap x de tim dien tich: ");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh chu nhat can tim la: ");
                        Console.WriteLine(hh.TimHinhCoDienTichLaX<HinhChuNhat>(x));
                        break;
                    //case 19
                    case Menu.TimHinhTronCoChuViLaX:

                        Console.WriteLine("Danh sach hinh tron: ");
                        Console.WriteLine(hh.TimHinh<HinhTron>() + "\n");
                        Console.Write("Nhap x de tim chu vi: ");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh tron can tim la: ");
                        Console.WriteLine(hh.TimHinhCoChuViLaX<HinhTron>(x));
                        break;
                    //case 20
                    case Menu.TimHinhTronCoDienTichLaX:

                        Console.WriteLine("Danh sach hinh tron: ");
                        Console.WriteLine(hh.TimHinh<HinhTron>() + "\n");
                        Console.Write("Nhap x de tim dien tich: ");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh tron can tim la: ");
                        Console.WriteLine(hh.TimHinhCoDienTichLaX<HinhTron>(x));
                        break;
                    //case 21 // coi lai ham vi khong the tai su dung
                    case Menu.SapXepDienTichTangDanHinhChuNhat:
                        Console.WriteLine("Dien tich cua hinh chu nhat truoc khi sap xep: ");
                        DanhSachHinhHoc ds = new DanhSachHinhHoc();
                        ds = hh.TimHinh<HinhChuNhat>();
                        Console.WriteLine(ds);
                        ds = ds.SapXepTheoChieuTangDT<HinhChuNhat>();
                        Console.WriteLine("\nDien tich cua hinh chu nhat da duoc sap xep theo chieu tang dan: ");
                        Console.WriteLine(ds);
                        break;
                    //case 22 
                    case Menu.SapXepChuViTangDanHCN:
                        Console.WriteLine("chu vi cua hinh chu nhat truoc khi sap xep: ");
                        ds = hh.TimHinh<HinhChuNhat>();
                        Console.WriteLine(ds);
                        ds=ds.SapXepTheoChieuTangCV<HinhChuNhat>();
                        Console.WriteLine("\nchu vi cua hinh chu nhat da duoc sap xep theo chieu tang dan: ");
                        Console.WriteLine(ds);
                        break;
                    // case 23
                    case Menu.TimHinhChuNhatCoCanhLaX:
                        Console.WriteLine("Danh sach hinh chu nhat: ");
                        Console.WriteLine(hh.TimHinh<HinhChuNhat>() + "\n");
                        Console.Write("Nhap x de tim hinh: ");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh chu nhat can tim la: ");
                        Console.WriteLine(hh.TimCanhLaX<HinhChuNhat>(x));
                        break;
                    // case 24
                    case Menu.TimHinhTronCoBanKinhLaX:
                        Console.WriteLine("Danh sach hinh tron: ");
                        Console.WriteLine(hh.TimHinh<HinhTron>() + "\n");
                        Console.Write("Nhap x de tim hinh: ");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh tron can tim la: ");
                        Console.WriteLine(hh.TimCanhLaX<HinhTron>(x));
                        break;
                    //case 25
                    case Menu.TimHinhVuongCoCanhLaX:
                        Console.WriteLine("Danh sach hinh vuong: ");
                        Console.WriteLine(hh.TimHinh<HinhVuong>() + "\n");
                        Console.Write("Nhap x de tim hinh: ");
                        x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Hinh vuong can tim la: ");
                        Console.WriteLine(hh.TimCanhLaX<HinhVuong>(x));
                        break;
                    // case 26
                    case Menu.SapXepDienTichGiamDanHinhChuNhat:
                        Console.WriteLine("Chu vi cua hinh chu nhat truoc khi sap xep: ");                  
                        ds = hh.TimHinh<HinhChuNhat>();
                        Console.WriteLine(ds);
                        ds = ds.SapXepTheoChieuGiamDT<HinhChuNhat>();
                        Console.WriteLine("Chu vi cua hinh chu nhat da duoc sap xep theo chieu giam dan: ");
                        Console.WriteLine(ds);
                        break;
                    // case 27
                    case Menu.TinhTongDienTichHinhVuong:
                        hh.TimHinh<HinhVuong>();
                        Console.Write("Tong dien tich hinh vuong la: ");
                        Console.Write(hh.TinhTongDienTich<HinhVuong>());
                        break;
                    // case 28
                    case Menu.TinhTongDienTichHinhChuNhat:
                        Console.WriteLine(hh.TimHinh<HinhChuNhat>());
                        Console.Write("Tong dien tich hinh chu nhat la: ");
                        Console.Write(hh.TinhTongDienTich<HinhChuNhat>());
                        break;
                    // case 29
                    case Menu.TinhTongDienTichHinhTron:
                        Console.WriteLine(hh.TimHinh<HinhTron>());
                        Console.Write("Tong dien tich hinh chu nhat la: ");
                        Console.Write(hh.TinhTongDienTich<HinhTron>());
                        break;
                    case Menu.TimDienTichLonNhatCuaDanhSach:
                       
                        Console.WriteLine("Hinh co dien tich lon nhat la: ");
                        Console.WriteLine(hh.TimDienTichLonNhatCuaDanhSach_());
                        break;
                    // case 30 // ham xoa
                    case Menu.XoaHinhCoDienTichLonNhatTrongDanhSach:
                        
                        
                        Console.WriteLine("Hinh co dien tich lon nhat la: ");
                        Console.WriteLine(hh.TimDienTichLonNhatCuaDanhSach_());
                        Console.WriteLine("Danh sach sau khi xoa la: ");
                        //var a=hh.XoaDienTichLonNhat();
                        hh.XoaDienTichLonNhat();
                        //Console.Write(a.ToString());
                        Console.Write(hh.ToString());
                        break;
                    // case 31 XoaTaiViTri
                    case Menu.XoaTaiViTri:

                        Console.WriteLine("danh sach hinh hoc: ");
                        Console.WriteLine(hh.ToString());
                        Console.WriteLine("Nhap vi tri can xoa: ");
                        int vt = int.Parse(Console.ReadLine());
                        Console.WriteLine(" Danh sach sau khi da xoa la: \n");
                        hh.XoaTaiViTriX(vt);
                        Console.WriteLine(hh.ToString());


                        break;
                    //Console.WriteLine("So hinh trong danh sach la "+hh.Dem());
                    //break;
                    case Menu.DemSoLuongHinhVuong:
                        Console.WriteLine("Danh sach hinh vuong: ");
                        Console.WriteLine(hh.TimHinh<HinhVuong>());
                        Console.WriteLine("So luong hinh vuong la: " + hh.Dem<HinhVuong>());
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
