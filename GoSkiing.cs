using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            int skiori = int.Parse(Console.ReadLine());
            int jackets = int.Parse(Console.ReadLine());
            int kaski = int.Parse(Console.ReadLine());
            int shoes = int.Parse(Console.ReadLine());
            double price = 0;
            price += jackets * 120;
            price += kaski * 75;
            price += shoes * 299.99;
            price = price * skiori;
            Console.WriteLine(price);
            price = price + (price * 0.2);
            Console.WriteLine(price);

            
        }
    }
}
