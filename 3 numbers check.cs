using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a == b && b == c)
            {
                Console.WriteLine("YES");

            }else Console.WriteLine("NO");

        }
    }
}
