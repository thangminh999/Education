using System;

namespace BaiTap17
{
    class Program
    {
        static void Main(string[] args)
        {
            int viTri = int.Parse(Console.ReadLine());
            switch (viTri)
            {
                case 1:
                    Console.WriteLine("Mercury.");
                    break;
                case 2:
                    Console.WriteLine("Venus.");
                    break;
                case 3:
                    Console.WriteLine("Earth.");
                    break;
                case 4:
                    Console.WriteLine("Mars.");
                    break;
                case 5:
                    Console.WriteLine(" Jupiter.");
                    break;
                case 6:
                    Console.WriteLine("Saturn.");
                    break;
                case 7:
                    Console.WriteLine("(Uranus.");
                    break;
                case 8:
                    Console.WriteLine("Neptune.");
                    break;
            }
                    Console.ReadKey();
        }
    }
}
