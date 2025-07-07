using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHinhHoc2
{
    class DanhSachHinhHoc
    {
        List<HinhHoc> collection = new List<HinhHoc>();
        public void Add(HinhHoc hh)
        {
            collection.Add(hh);
        }
        public override string ToString()
        {
            string s = "loai hinh".PadRight(15) + " kich thuoc ".PadRight(25) + "chu vi".PadRight(25) + "dien tich ".PadRight(15); ;
            foreach (var item in collection)
            {
                s += "\n" + item;
            }
            return s;
        }
        public void NhapTuFile()
        {
            HinhHoc hh = new HinhHoc();
            string path = @"data1.txt";
            StreamReader sr = new StreamReader(path);
            string type, str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] line = str.Split();
                type = line[0];
                switch (type)
                {
                    case "HV":
                        hh = new HinhVuong(int.Parse(line[1]));
                        break;
                    case "HCN":
                        hh = new HinhChuNhat(int.Parse(line[1]), int.Parse(line[2]));
                        break;
                    case "HT":
                        hh = new HinhTron(int.Parse(line[1]));
                        break;
                }
                collection.Add(hh);
            }
        }
        #region DemSoLuongCacHinh
        public int Dem<loaihinh>()
        {
            int dem = 0;
            foreach(var item in collection)
            {
                if(item is loaihinh)
                {
                    if (item is HinhVuong)
                        dem++;
                    if (item is HinhTron)
                        dem++;
                    if (item is HinhChuNhat)
                        dem++;
                }
            }
            return dem;
        }
        #endregion
        #region TimDienTichLonNhatTheoLoaiHinh
        public float TimDienTichLonNhat<loaihinh>()
        {
            float max = -1;
            foreach (var item in collection)
            {
                float dt = item.TinhDT();
                if (item is loaihinh && dt > max)
                    max = dt;

            }
            return max;
        }
        public DanhSachHinhHoc TimDienTichLonNhat2<loaihinh>()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimDienTichLonNhat<loaihinh>();
            foreach (var item in collection)
            {
                float dt = item.TinhDT();
                if (item is loaihinh && dt == max)
                    kq.Add(item);

            }
            return kq;
        }
        #endregion
        #region TimDienTichLonNhatTheoDanhSach
        // Tim dien tich lon nhat cua danh sach
        public float TimDienTichLonNhatCuaDanhSach()
        {
            float max = -1;
            foreach (var item in collection)
            {
                float dt = item.TinhDT();
                if (item is HinhHoc && dt > max)
                    max = dt;

            }
            return max;
        }

        public DanhSachHinhHoc TimDienTichLonNhatCuaDanhSach_()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimDienTichLonNhatCuaDanhSach();
            foreach (var item in collection)
            {
                float dt = item.TinhDT();
                if (item is HinhHoc && dt == max)
                    kq.Add(item);

            }
            return kq;
        }
        #endregion
        #region TimChuViLonNhat2<loaihinh>()
        public float TimChuViLonNhat<loaihinh>()
        {
            float max = -1;
            foreach (var item in collection)
            {
                float cv = item.TinhDT();
                if (item is loaihinh && cv > max)
                    max = cv;

            }
            return max;
        }
        public DanhSachHinhHoc TimChuViLonNhat2<loaihinh>()
        {

            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimChuViLonNhat<loaihinh>();
            foreach (var item in collection)
            {
                float cv = item.TinhCV();
                if (item is loaihinh && cv == max)
                    kq.Add(item);

            }
            return kq;


        }
        #endregion
        #region TimChuViNhoNhat2<loaihinh>()
        public DanhSachHinhHoc TimChuViNhoNhat2<loaihinh>()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float min = TimChuViNhoNhat<loaihinh>();
            foreach (var item in collection)
            {
                float cv = item.TinhCV();
                if (item is loaihinh && cv == min)
                    kq.Add(item);

            }
            return kq;
        }

        public float TimChuViNhoNhat<loaihinh>()
        {
            float min = 100;
            foreach (var item in collection)
            {
                float cv = item.TinhCV();
                if (item is loaihinh && cv < min)
                    min = cv;
            }
            return min;
        }
        #endregion
        #region TimDienTichNhoNhat<loaihinh>()

        // Tim Dien tich nho nhat
        public float TimDienTichNhoNhat<loaihinh>()
        {
            float min = 100;
            foreach (var item in collection)
            {
                float dt = item.TinhDT();
                if (item is loaihinh && dt < min)
                    min = dt;

            }
            return min;
        }
        public DanhSachHinhHoc TimDienTichNhoNhat2<loaihinh>()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimDienTichNhoNhat<loaihinh>();
            foreach (var item in collection)
            {
                float dt = item.TinhDT();
                if (item is loaihinh && dt == max)
                    kq.Add(item);

            }
            return kq;
        }
        #endregion
        #region TimHinh
        public DanhSachHinhHoc TimHinh<loaihinh>()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();

            foreach (var item in collection)
            {

                if (item is loaihinh)
                    kq.Add(item);

            }
            return kq;
        }
        #endregion
        #region TimHinhCoChuViLaX<loaihinh>(float x)
        public DanhSachHinhHoc TimHinhCoChuViLaX<loaihinh>(float x)
        {

            //cach 1
            //DanhSachHinhHoc kq = new DanhSachHinhHoc();
            //foreach (var item in collection)
            //{
            //    if (item is loaihinh && item.TinhCV() == x)
            //        kq.Add(item);

            //}
            //return kq;
            //}
            //cach 2 rut gon code 
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            kq.collection = collection.FindAll(p => p is loaihinh && p.TinhCV() == x);
            return kq;
        }

        #endregion
        #region TimHinhCoDienTichLaX<loaihinh>(float x)

        public DanhSachHinhHoc TimHinhCoDienTichLaX<loaihinh>(float x)
        {


            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is loaihinh && item.TinhDT() == x)
                    kq.Add(item);

            }
            return kq;
        }
        #endregion
        #region  SapXep
        // Sap xep tang theo DT
        // orderBy la tang
        public DanhSachHinhHoc SapXepTheoChieuTangDT<loaihinh>()
        {
            DanhSachHinhHoc tam = new DanhSachHinhHoc();
            tam.collection = collection.OrderBy(p => p.TinhDT()).ToList();
            return tam;

        }
        // Sap xep giam theo DT
        // OrderByDescending la giam
        public DanhSachHinhHoc SapXepTheoChieuGiamDT<loaihinh>()
        {
            DanhSachHinhHoc tam = new DanhSachHinhHoc();
            tam.collection = collection.OrderByDescending(p => p.TinhDT()).ToList();
            return tam;

        }

        // Sap xep tang theo CV
        // OrderBy la tang
        public DanhSachHinhHoc SapXepTheoChieuTangCV<loaihinh>()
        {
            DanhSachHinhHoc tam = new DanhSachHinhHoc();
            tam.collection = collection.OrderBy(p => p.TinhCV()).ToList();
            return tam;

        }
        // Sap xep giam theo CV
        public DanhSachHinhHoc SapXepTheoChieuGiamCV<loaihinh>()
        {
            DanhSachHinhHoc tam = new DanhSachHinhHoc();
            tam.collection = collection.OrderBy(p => p.TinhCV()).ToList();
            return tam;

        }
        #endregion
        #region TimCanh
        // Hàm tìm cạnh
        public DanhSachHinhHoc TimCanhLaX<loaihinh>(float x)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is loaihinh)
                {
                    if (item is HinhVuong && ((HinhVuong)item).canh == x)
                        kq.Add(item);
                    if (item is HinhChuNhat && ((((HinhChuNhat)item).dai == x) || ((HinhChuNhat)item).rong == x))
                        kq.Add(item);
                    if (item is HinhTron && ((HinhTron)item).banKinh == x)
                        kq.Add(item);
                }
            }
            return kq;
        }
        #endregion
        #region TinhTong


        // Tinh Tong
        public float TinhTongDienTich<loaihinh>()
        {
            float tong = 0;
            foreach (var item in collection)
            {
                if (item is loaihinh) tong += item.TinhDT();
            }
            return tong;
        }
        #endregion
        #region XoaDienTichLonNhat
        public DanhSachHinhHoc XoaDienTichLonNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            kq.collection = collection;
            float max = TimDienTichLonNhatCuaDanhSach();
            List<HinhHoc> MaxList = collection.Where(x => x.TinhDT() == max).ToList();
            foreach (var item in MaxList)
            {
                kq.collection.Remove(item);
            }
            return kq;
        }
        #endregion
        #region XoaTaiViTri
        int Dem()
        {
            int dem = 0;
            for (int i = 0; i < 10; i++)
            {
                foreach (var item in collection)
                {
                    if (item is HinhHoc)
                        dem++;
                }

            }
            return dem;

        }
        //public DanhSachHinhHoc XoaTaiViTriX(int vt)
        public void XoaTaiViTriX(int vt)
        {

            //DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in collection)
            {
                if (item is HinhHoc)
                    //kq.collection.RemoveAt(vt);
                    collection.RemoveAt(vt);
            }
            //return kq;
        }
        #endregion // Xoa khong duoc
    }
}

