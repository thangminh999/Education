using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc
{
    class DanhSachHinhHoc
    {
        List<HinhHoc> collection = new List<HinhHoc>();
        public void Them(HinhHoc hh)
        {
            collection.Add(hh);
        }
        public void NhapTuFile()
        {
            string path = "E:\\data1.txt";
            StreamReader sr = new StreamReader(path);
            HinhHoc hh = null;
            string str = " ", kieuHinh;
            while((str=sr.ReadLine())!=null)
            {
                string[] line = str.Split(' ');
                kieuHinh = line[0];

                switch (kieuHinh)
                {
                    case "HV":
                        hh = new HinhVuong(float.Parse(line[1]));
                        break;
                    case "HT":
                        hh = new HinhTron(float.Parse(line[1]));
                        break;
                    case "HCN":
                        hh = new HinhChuNhat(float.Parse(line[1]), float.Parse(line[2]));
                        break;
                }
                Them(hh);
                
            }
        }


        public override string ToString()
        {
            string s = "";
            foreach(var item in collection)
            {

                s += "\n" + item.ToString();
            }
            return s;
        }

  
        float TimDienTichHinhVuongLonNhat()
        {
            float max = -1;
            foreach(var item in collection)
            {
                if(item is HinhVuong)
                {
                    float dt = ((HinhVuong)item).TinhDienTich();
                    if (dt > max)
                        max = dt;
                }

            }
            return max;
        }
        public DanhSachHinhHoc TimHinhVuongCoDienTichLonNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimDienTichHinhVuongLonNhat();
            foreach(var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() == max)
                    kq.Them(item);
            }
            return kq;
        }

 
        public DanhSachHinhHoc TimHinhVuongCoDienTichLaX(int x)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach(var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() == x )
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachHinhHoc TimHinhVuongCoChuViLaX(int x)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhChuVi() == x)
                    kq.Them(item);
            }
            return kq;
        }
        float TimDienTichHinhVuongNhoNhat()
        {
            float min=100;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    float dt = ((HinhVuong)item).TinhDienTich();
                    if (min>dt)
                        min = dt;
                }

            }
            return min;
        }
        public DanhSachHinhHoc TimHinhVuongCoDienTichNhoNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float min = TimDienTichHinhVuongNhoNhat();
            foreach (var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhDienTich() == min)
                    kq.Them(item);
            }
            return kq;
        }
        float TimChuViHinhVuongNhoNhat()
        {
            float min = 100;
            foreach(var item in collection)
            {
                if(item is HinhVuong)
                {
                    float dt = ((HinhVuong)item).TinhChuVi();
                    if (min > dt)
                        min = dt;
                }
            }
            return min;
        }
        public DanhSachHinhHoc TimHinhVuongCoChuViNhoNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float min = TimChuViHinhVuongNhoNhat();
            foreach (var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhChuVi() == min)
                    kq.Them(item);
            }
            return kq;
        }
        float TimCanhHinhVuongNhoNhat()
        {
            float min = 100;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    float dt = ((HinhVuong)item).canh;
                    if (min > dt)
                        min = dt;
                }
            }
            return min;
        }
        public DanhSachHinhHoc TimHinhVuongCoCanhNhoNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float min = TimCanhHinhVuongNhoNhat();
            foreach (var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).canh == min)
                    kq.Them(item);
            }
            return kq;
        }
        float TimCanhHinhVuongLonNhat()
        {
            float max = -1;
            foreach (var item in collection)
            {
                if (item is HinhVuong)
                {
                    float dt = ((HinhVuong)item).canh;
                    if (max < dt)
                        max = dt;
                }
            }
            return max;
        }
        public DanhSachHinhHoc TimHinhVuongCoCanhLonNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimCanhHinhVuongLonNhat();
            foreach (var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).canh == max)
                    kq.Them(item);
            }
            return kq;
        }
        public float TinhTongDienTichHinhVuong()
        {
            float tong = 0;
            foreach(var item in collection)
            {
                if (item is HinhVuong)
                    tong = tong + ((HinhVuong)item).TinhDienTich();
            }
           return tong;
        }
        public float TinhTongChuViHinhVuong()
        {
            float tong = 0;
            foreach(var item in collection)
            {
                if (item is HinhVuong)
                    tong = tong + ((HinhVuong)item).TinhChuVi();
            }
            return tong;
        }
       public float DemSoLuongHinhVuong()
        {
            int dem = 0;
            foreach(var item in collection)
            {
                if (item is HinhVuong)
                {
                    dem++;
                  
                }
                

            }
            return dem;
        }
        public DanhSachHinhHoc XuatHinhVuong()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach(var item in collection)
            {
               if (item is HinhVuong)
                    kq.Them(item);
            }
            return kq;
        }
        public float DemSoLuongHinhTron()
        {
            int dem = 0;
            foreach (var item in collection)
            {
                if (item is HinhTron)
                {
                    dem++;

                }


            }
            return dem;
        }
        public DanhSachHinhHoc XuatHinhTron()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is HinhTron)
                    kq.Them(item);
            }
            return kq;
        }
        public float DemSoLuongHinhChuNhat()
        {
            int dem = 0;
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                {
                    dem++;

                }


            }
            return dem;
        }
        public DanhSachHinhHoc XuatHinhChuNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is HinhChuNhat)
                    kq.Them(item);
            }
            return kq;
        }

    }
}
