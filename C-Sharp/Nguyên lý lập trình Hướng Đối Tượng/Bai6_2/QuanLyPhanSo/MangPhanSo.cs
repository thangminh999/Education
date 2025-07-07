﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;// sử dụng thư viện để làm việc với stream
namespace QuanLyPhanSo
{
    class MangPhanSo
    {
        public PhanSo[] a = new PhanSo[100];
        public int length;
        public void Nhap()
        {
            Console.WriteLine("Nhap vao chieu dai mang ");
            length = int.Parse(Console.ReadLine());
            for(int i=0;i<length;i++)
            {
                a[i]=new PhanSo();
                a[i].Nhap();
            }
        }
        public void Xuat()
        {
            for(int i=0;i<length;i++)
            {
                a[i].Xuat();
            }
        }
        public void Them(PhanSo x)
        {
            a[length] = x;
            length++;
        }
        public void NhapTuFile()
        {
            string path="D:\\data2.txt";
            StreamReader sr = new StreamReader(path);
            string s = " ";
            while((s=sr.ReadLine())!=null)
            {
                string[] tam = s.Split('/');
                int tu = int.Parse(tam[0]);
                int mau = int.Parse(tam[1]);
                Them(new PhanSo(tu, mau));
            }

        }
        public void NhapNgauNhien()
        {
            Console.Write("Nhap chieu dai mang: ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for(int i=0;i<length;i++)
            {
                a[i] = new PhanSo(r.Next(10), r.Next(10));
            }
        }
        // tìm phân số lớn nhất
        public PhanSo TimMax()
        {
            PhanSo max = new PhanSo(int.MinValue, 1);
            for(int i=0;i<length;i++)
            {
                float x = a[i].tu / a[i].mau;
                float y = max.tu / max.mau;
                if (x > y) max = a[i];
            }
            return max;
        }
        public MangPhanSo TimPhanSoCoMauLa(int x)
        {
            MangPhanSo kq = new MangPhanSo();
            for (int i=0;i<length;i++)
            {
                if (a[i].mau == x)
                    kq.Them(a[i]);
            }
            return kq;
        }
       
        
    }
}
