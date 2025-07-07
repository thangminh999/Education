using System;

namespace BaiTap18
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Name, laTinh="ay";// chuoi de noi
           //Name = Console.ReadLine();// nhap chuoi
           // Name = Name.Trim();// xoa ki tu trang
            Console.Write("Moi ban nhap chuoi: ");
            String Name, laTinh = "ay";
            Name = Console.ReadLine();// nhap chuoi
            Name = Name.Trim();// xoa ki tu trang
            Console.Write("Ban vua nhap chuoi: {0}\n", Name);
            string tmp = Name[0].ToString();
            Name = Name.Substring(1);// xoa ki dau tien trong chuoi vua nhap
            string fullname = Name + ""+tmp+""+laTinh;// noi chuoi lai voi nhau
            Console.WriteLine("ten laTinh: {0}",fullname);
            Console.ReadKey();

        }
    }
}
