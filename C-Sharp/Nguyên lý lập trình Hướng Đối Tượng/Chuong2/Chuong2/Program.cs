using System;


namespace Chuong2
{
    class Program
    {
        private const double cM = 2.54;

        static void Main(string[] args)
        {
            double a = 4.2;
            Console.WriteLine("{0} inch = {1} cm",a,a*cM);
            Console.ReadKey();
        }
    }
}
