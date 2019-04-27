using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool onleft = x == x1 && y >= y1 && y <= y2;
            bool onright = x == x2 && y >= y1 && y <= y2;
            bool onup = y == y1 && x >= x1 && x <= x2;
            bool ondown = y == y2 && x >= x1 && x <= x2;
            if (onleft || onright || onup || ondown)
            {
                Console.WriteLine("Border");
            }
            else if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                Console.WriteLine("Inside");
            }
            else Console.WriteLine("Outside");

        }
    }
}
