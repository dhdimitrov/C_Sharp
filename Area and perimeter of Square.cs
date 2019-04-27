using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a = 0;
            double b = 0;
            if (x1 > x2) a = x1 - x2;
            else a = x2 - x1;
            if (y1 > y2) b = y1 - y2;
            else b = y2 - y1;
            double perimeter = 2*a + 2*b;
            double s = a * b;
            Console.WriteLine(perimeter);
            Console.WriteLine(s);

        }
    }
}
