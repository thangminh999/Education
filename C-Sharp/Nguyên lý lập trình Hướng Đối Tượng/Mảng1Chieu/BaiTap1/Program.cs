using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Nhập Xuất dữ liệu
namespace BaiTap1
{
    class Program
    {
        // Nhập Xuất dữ liệu
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] dulieu = new int[100];
            int n = 0;
            Console.Write("Nhập dữ liệu vào số phần tử của mảng: ");
            n = int.Parse(Console.ReadLine());
            //// duyệt qua các phần tử của mảng để nhập;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("dulieu[{0}]= ", i);

            //    dulieu[i] = int.Parse(Console.ReadLine());


            //}
            //Console.Write("Mảng vừa nhập là: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("\t" + dulieu[i]);
            //}
            //Console.ReadLine();


            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                dulieu[i] = r.Next(100);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t" + dulieu[i]);
            }
            Console.ReadLine();
            int Tong = 0;
            for(int i=0;i<n;i++)
            {
                Tong = Tong + dulieu[i];
            }
            Console.Write("Tong cac so vua nhap la: " + Tong);
            Console.Read();
        }

    }
}
