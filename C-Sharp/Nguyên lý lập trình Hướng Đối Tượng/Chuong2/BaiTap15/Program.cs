using System;

namespace BaiTap15
{
    class Program
    {
        static void Main(string[] args)
        {
            int DoF = 0;
            Console.Write("moi ban ban nhap :");
            DoF = int.Parse(Console.ReadLine());
            double quiDoiC = (DoF - 32) * 5 / 9;
            Console.WriteLine("{0} F to {1} C", string.Format("{0:0.0}",DoF),string.Format("{0:0.0}", quiDoiC));
            Console.ReadKey();
        }
    }
}
