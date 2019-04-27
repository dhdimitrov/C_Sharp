using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
            double perimeter = 2 * Math.PI * r; 
            //Console.WriteLine(area);

            Console.WriteLine(Math.Round(area, 2));
            Console.WriteLine(Math.Round(perimeter, 2));







            
        }
    }
}
