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
            string path = @"data5.txt";
            StreamReader sr = new StreamReader(path);
            string str = " ";
            while ((str = sr.ReadLine()) != null)
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
            for (int i = 0; i < length; i++)
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
            for (int i = 0; i < length; i++)
            {
                int dem = DemSoDTTheoThueBao(a[i].soCMND);
                if (dem > max)
                    max = DemSoDTTheoThueBao(a[i].soCMND);
            }
            return max;

        }
        public bool CoChua(ThueBao tb)
        {
            for (int i = 0; i < length; i++)
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

            for (int i = 0; i < length; i++)
            {
                if (DemSoDTTheoThueBao(a[i].soCMND) == max && !kq.CoChua(a[i]))
                    kq.Them(a[i]);
            }
            return kq;
        }
        public int DemSoDTXuatHienTheoDiaChi(string diaChi)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].diaChi == diaChi)
                    dem++;
            }
            return dem;
        }
        public int DemSoThueBaoXuatHienItNhat()
        {
            int min = 10;
            for (int i = 0; i < length; i++)
            {
                int dem = DemSoDTXuatHienTheoDiaChi(a[i].diaChi);
                if (min > dem)
                    min = dem;
            }
            return min;
        }
        public bool CoChua2(ThueBao tb)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].diaChi == tb.diaChi)
                    return true;
            }
            return false;
        }
        public List<string> TimThueBaoCoSDTItNhatTheoDiaChi()
        {
            List<string> kq = new List<string>();
            int min = DemSoThueBaoXuatHienItNhat();
            for (int i = 0; i < length; i++)
            {
                if (DemSoDTXuatHienTheoDiaChi(a[i].diaChi) == min && !kq.Contains(a[i].diaChi))
                    kq.Add(a[i].diaChi);
            }
            return kq;
        }
        public int DemThueBaoCoSDTNhieuNhatTheoDC()
        {
            int max = -1;
            for (int i = 0; i < length; i++)
            {
                int dem = DemSoDTXuatHienTheoDiaChi(a[i].diaChi);
                if (max < dem)
                    max = dem;
            }
            return max;
        }
        public List<string> TimThueBaoCoSDTNhieuNhatTheoDC()
        {
            List<string> kq = new List<string>();
            int max = DemThueBaoCoSDTNhieuNhatTheoDC();
            for (int i = 0; i < length; i++)
            {
                if (DemSoDTXuatHienTheoDiaChi(a[i].diaChi) == max && !kq.Contains(a[i].diaChi))
                    kq.Add(a[i].diaChi);
            }
            return kq;
        }
        public int DemThueBaoSoHuuSDT(string hoTen)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].hoTen == hoTen)
                    dem++;
            }
            return dem;
        }
        public int DemThueBaoSoHuuSDTItNhat()
        {
            int min = 10;
            for (int i = 0; i < length; i++)
            {
                int dem = DemThueBaoSoHuuSDT(a[i].hoTen);
                if (min > dem)
                    min = dem;
            }
            return min;
        }
    
        public List<string> TimThueBaoSoHuuSDTItNhat()
        {
            List<string> kq = new List<string>();
            int min = DemThueBaoSoHuuSDTItNhat();
            for(int i=0;i<length;i++)
            {
                if (DemThueBaoSoHuuSDT(a[i].hoTen) == min && !kq.Contains(a[i].hoTen))
                    kq.Add(a[i].hoTen);
            }
            return kq;

        }

    }
}
