using System;

namespace BaiTap6
{
    class Program
    {
        private const double cM = 2.54;
        static void Main(string[] args)
        {
            Console.Write("Hay nhap vao so inch: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("===================");
            Console.WriteLine("{0} inch = {1} cm", a, a*cM );
            Console.ReadKey();
        }
    }
}
