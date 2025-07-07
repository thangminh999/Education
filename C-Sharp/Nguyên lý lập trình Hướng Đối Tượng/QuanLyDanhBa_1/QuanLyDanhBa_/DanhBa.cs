using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa_
{
    class DanhBa
    {
        ThueBao[] a = new ThueBao[100];
        int length = 0;
        public void Them(ThueBao tb)
        {
            a[length++] = tb;
        }
        public void NhapTuFile()
        {
            string path =  @"data.txt";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while((str=sr.ReadLine())!=null)
            {
                Them(new ThueBao(str));
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < length; i++)
            {
                a[i].Xuat();
            }
        }
        public override string ToString()
        {
            string s = "";
            for(int i=0;i<length;i++)
            {
                int k = i + 1;
                s += k.ToString() + ") " + a[i];

            }
            return s;
        }
        public int DemSoDTTheoThueBao(string cmnd)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].soCMND == cmnd)
                    dem++;

            }
            return dem;
        }
            public int DemThueBaoXuatHienNhieuNhat()
        {
            int max = -1;
            for(int i=0;i<length;i++)
            {
                int dem = DemSoDTTheoThueBao(a[i].soCMND);
                if (dem> max)
                    max = DemSoDTTheoThueBao(a[i].soCMND);
            }
            return max;
        
        }
        public bool CoChua(ThueBao tb)
        {
            for(int i=0;i<length;i++)
            {
                if (a[i].soCMND == tb.soCMND)
                    return true;

            }
            return false;
        }
        public DanhBa TimThueBaoCoNhieuSDT()
        {
            DanhBa kq = new DanhBa();
            int max = DemThueBaoXuatHienNhieuNhat();
           
            for(int i=0;i<length;i++)
            {
                if (DemSoDTTheoThueBao(a[i].soCMND) == max && !kq.CoChua(a[i]))
                    kq.Them(a[i]);
            }
            return kq;
        }
    }
}
