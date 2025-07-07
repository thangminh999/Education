using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiMayTinh
{
    class MayTinh
    {
        List<IThietBi> collection = new List<IThietBi>();
        public void Them(IThietBi tb)
        {
            collection.Add(tb);
        }
        public float TongGia()
        {
            float tong = 0;
            foreach (var item in collection)
            {
                tong += item.Gia;
            }
            return tong;
        }
    
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
            {
                s += item + "\n";
            }
            s += "tổng giá là: " + TongGia();
            return s;
        }
        public int DemTheoHang(string hang)
        {
            int dem = 0;
            foreach (var item in collection)
            {

                if (item.HangSX == hang) dem++;
            }
            return dem;
            //return collection.Count(x => x.HangSX == hang);
        }
        public List<string> TimCPUTheoHang(string hang)
        {
            List<string> kq = new List<string>();
            foreach(var item in collection)
            {
                if ((item is CPU && !(item is Ram) && !(item is OCung)) && item.HangSX == hang)
                    kq.Add(item.HangSX);
                        
                        
                   
            }
            return kq;
           
        }
        public List<string> TimDanhSachHang()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                kq.Add(item.HangSX);
            }
            return kq;
        }
        #region CPU min max
        public float TimGiaCPUMin()
        {
            float min = float.MaxValue;
            foreach (var item in collection)
            {
                if (item is CPU && !(item is Ram)&&! (item is OCung) )
                    if (item.Gia < min) min = item.Gia;
            }
            return min;
        }
        public float TimGiaCPUMax()
        {
            float max = float.MinValue;
            foreach(var item in collection)
            {
                if (item is CPU && !(item is Ram) && !(item is OCung))
                    if (item.Gia > max) max = item.Gia;
            }
            return max;
        }
        #endregion
        #region Ram min max

        // min
        public float TimGiaRamMin()
        {
            float min = float.MaxValue;
            foreach(var item in collection)
            {
                if (item is Ram)
                    if (item.Gia < min) min = item.Gia;
            }
            return min;
           
        }
        //max
        public float TimGiaRamMax()
        {
            float max = float.MinValue;
            foreach (var item in collection)
            {
                if (item is Ram)
                    if (item.Gia > max) max = item.Gia;
            }
            return max;

        }
        #endregion
        #region Tìm hãng có nhiều CPU nhất
        //public int DemCPUCuaHang(string hangSX)
        //{
        //    int dem = 0;
        //    foreach(var item in collection)
        //    {
        //        if (item is CPU && ((CPU)item).HangSX.CompareTo(hangSX)==0)
        //            dem++;
        //    }
        //    return dem;
        //}


        public int DemCPUTheoHang(string hang)
        {
            int dem = 0;
            foreach (var item in collection)
            {
                if (item is CPU && !(item is Ram) && item.HangSX == hang)
                    dem++;
            }
            return dem;
        }
        public int DemRamTheoHang(string hang)
        {
            int dem = 0;
            foreach(var item in collection)
            {
                if (item is Ram && item.HangSX == hang)
                    dem++;

            }
            return dem;
        }
       
        #endregion
    }
}
