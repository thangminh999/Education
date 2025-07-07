using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMayTinh
{
    class DanhSachMayTinh
    {
        List<MayTinh> collection = new List<MayTinh>();
        public void NhapTuFile()
        {
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                // CPU,Intel,300 * CPU,Intel,300 * RAM,SamSung,50 * HDD,Seagate,500
                MayTinh m = new MayTinh();
                string[] s = str.Split('*');
                foreach (string item in s)
                {
                    if (item.IndexOf("CPU") == 0)
                        m.Them(new CPU(item));
                    if (item.IndexOf("RAM") == 0)
                        m.Them(new Ram(item));
                    if (item.IndexOf("HDD") == 0 || item.IndexOf("SSD") == 0)
                        m.Them(new OCung(item));
                }
                Them(m);
            }
        }
        public void Them(MayTinh mt)
        {
            collection.Add(mt);
        }
        #region Max
        public DanhSachMayTinh TimGiaMaxTrongDanhSach()
        {
            //float max = collection.Max(x => x.TongGia());
            float max = TimGiaCaoNhat();
            DanhSachMayTinh kq = new DanhSachMayTinh();
            foreach (var item in collection)
            {
                if (item.TongGia() == max)
                    kq.Them(item);
            }
            return kq;
        }
        public float TimGiaCaoNhat()
        {
            float max = -1;
            foreach (var item in collection)
            {
                if (max < item.TongGia())
                    max = item.TongGia();
            }
            return max;
        }
        #endregion
        #region Min
        public DanhSachMayTinh TimGiaMinTrongDanhSach()
        {
            float min = collection.Min(x => x.TongGia());
            DanhSachMayTinh kq = new DanhSachMayTinh();
            foreach (var item in collection)
            {
                if (item.TongGia() == min)
                    kq.Them(item);
            }
            return kq;

        }
        #endregion

        public override string ToString()
        {

            string s = "";
            foreach (var item in collection)
            {
                s += item + "\n";
            }
            return s;

        }
        public int DemThietBiTheoHang(string hang)
        {
            int dem = 0;
            foreach (var item in collection)
            {
                
                dem += item.DemTheoHang(hang);
            }
            return dem;
            //return collection.Sum(x => x.DemTheoHang(hang));
        }
       
        /// <summary>
        /// Ham them 1 ds chuoi vao ds chuoi, tranh trung nhau
        /// </summary>
        /// <param name="kq">Danh sach goc</param>
        /// <param name="hang">Danh sach hang</param>
        public void ThemDanhSachHang(List<string> kq, List<string> hang)
        {
            foreach (var item in hang)
            {
                if (!kq.Contains(item))
                    kq.Add(item);
            }
        }
        public List<string> TimDanhSachHang()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                ThemDanhSachHang(kq, item.TimDanhSachHang());
            }
            return kq;
        }
        public int TimThietBiNhieuNhat()
        {
            int max = -1;
            List<string> ds = TimDanhSachHang();
            foreach (var item in ds)
            {
                int tam = DemThietBiTheoHang(item);
                if (max < tam)
                    max = tam;
            }
            return max;
        }
        public List<string> TimHangXuatHienNhieuNhat()
        {
            List<string> kq = new List<string>();
            int max = TimThietBiNhieuNhat();
            List<string> ds = TimDanhSachHang();
            foreach (var item in ds)
            {
                int tam = DemThietBiTheoHang(item);
                if (tam == max)
                    kq.Add(item);
            }
            return kq;
        }

        #region Tim Giá của CPU Min  
        public DanhSachMayTinh TimCPUGiaMin()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float min = LayCPUReNhat();
            foreach (var item in collection)
            {
                if (min == item.TimGiaCPUMin()) kq.Them(item);
            }
            return kq;
        }
        public float LayCPUReNhat()
        {
            float min = float.MaxValue;
            foreach (var item in collection)
            {
                if (item.TimGiaCPUMin() < min) min = item.TimGiaCPUMin();
            }
            return min;
        }
        #endregion
        #region Tìm Giá CPU Max
        public DanhSachMayTinh TimCPUGiaMax()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float max = LayCPUDatNhat();
            foreach (var item in collection)
            {
                if (max == item.TimGiaCPUMax()) kq.Them(item);
            }
            return kq;
        }
        public float LayCPUDatNhat()
        {
            float max = float.MinValue;
            foreach (var item in collection)
            {
                if (item.TimGiaCPUMax() > max) max = item.TimGiaCPUMax();
            }
            return max;
        }
        #endregion
        #region TimRamMin
        public DanhSachMayTinh TimRamGiaMin()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float min = LayRamGiaMin();
            foreach (var item in collection)
            {
                if (min == item.TimGiaRamMin())
                    kq.Them(item);
            }
            return kq;
        }
        public float LayRamGiaMin()
        {
            float min = float.MaxValue;
            foreach (var item in collection)
            {
                if (item.TimGiaRamMin() < min)
                    min = item.TimGiaRamMin();
            }
            return min;
        }
        #endregion
        #region Tim Ram giá MAX
        public DanhSachMayTinh TimRamGiaMax()
        {
            DanhSachMayTinh kq = new DanhSachMayTinh();
            float max = LayRamGiaMax();
            foreach (var item in collection)
            {
                if (max == item.TimGiaRamMax())
                    kq.Them(item);
            }
            return kq;
        }
        public float LayRamGiaMax()
        {
            float max = float.MinValue;
            foreach (var item in collection)
            {
                if (item.TimGiaRamMax() > max)
                    max = item.TimGiaRamMax();
            }
            return max;
        }
        #endregion
        #region TimHangCoCPUMax,MIn
        //CPU

        public int TimTongCPUSL(string hang)
        {
            int tong = 0;
            foreach (var item in collection)
            {
                tong += item.DemCPUTheoHang(hang);
            }
            return tong;
        }
        // Tìm hãng có nhiều CPU sử dụng nhất 
        public int TimSoLuongMax()
        {

            int max = int.MinValue;
            List<string> kq = TimDanhSachHang();
            foreach (var item in kq)
            {
                int tam = TimTongCPUSL(item);
                if (tam > max)
                    max = tam;
            }
            return max;
        }

        public List<string> CPUXHMaxTheoHang()
        {
            List<string> list = new List<string>();
            int max = TimSoLuongMax();
            List<string> cPU = TimDanhSachHang();
            foreach (var item in cPU)
            {
                if (TimTongCPUSL(item) == max && !(list.Contains(item)))
                    list.Add(item);

            }
            return list;
        }
        // Tìm Hãng có CPU ít sử dụng nhất

        public int TimSoLuongCPUMin()
        {
            int min = int.MaxValue;
            List<string> kq = TimDanhSachHang();
            foreach (var item in kq)
            {
                int tam = TimTongCPUSL(item);
                if (tam < min)
                    min = tam;
            }
            return min;
        }
        public List<string> CPUXHMinTheoHang()
        {
            List<string> list = new List<string>();
            int min = TimSoLuongCPUMin();
            List<string> cPU = TimDanhSachHang();
            foreach (var item in cPU)
            {
                if (TimTongCPUSL(item) == min && !(list.Contains(item)))
                    list.Add(item);
            }
            return list;
        }
        #endregion
        #region TimMaxMinRamTheoHang
        public int TongRamSL(string hang)
        {
            int tong = 0;
            foreach (var item in collection)
            {
                tong += item.DemRamTheoHang(hang);
            }
            return tong;
        }
        // Tìm hãng có nhiều Ram sử dụng nhất
        public int TimSoLuongRamMax()
        {
            int max = int.MinValue;
            List<string> kq = TimDanhSachHang();
            foreach (var item in kq)
            {
                int tam = TongRamSL(item);
                if (tam > max)
                    max = tam;
            }
            return max;
        }
        public List<string> TimRamXHMaxTheoHang()
        {
            List<string> list = new List<string>();
            int max = TimSoLuongRamMax();
            List<string> rAM = TimDanhSachHang();
            foreach (var item in rAM)
            {
                if (TongRamSL(item) == max && !(list.Contains(item)))
                    list.Add(item);
            }
            return list;
        }
        // Tìm hãng sử dụng Ram ít nhất
        public int TimSoLuongRamMin()
        {
            int min = int.MaxValue;
            List<string> kq = TimDanhSachHang();
            foreach (var item in kq)
            {
                int tam = TongRamSL(item);
                if (tam < min)
                    min = tam;
            }
            return min;

        }
        public List<string> TimRamXHMinTheoHang()
        {
            List<string> list = new List<string>();
            int min = TimSoLuongRamMin();
            List<string> rAM = TimDanhSachHang();
            foreach (var item in rAM)
            {
                if (TongRamSL(item) == min && !(list.Contains(item)))
                    list.Add(item);
            }
            return list;

        }

        #endregion
        //#region Xoa
        //public void XoaCPUTheoHang(string hang)
        //{

           
        //    foreach (var item in collection)
        //    {

        //        collection.RemoveAll(x=>x.TimCPUTheoHang(hang));

        //    }
        //}
        #endregion
    }
}
