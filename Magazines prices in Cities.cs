using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double broi = double.Parse(Console.ReadLine());
            double price = 0;
            if(city == "Sofia")
            {
                if (product == "coffee")
                {
                    //Console.WriteLine("Total : " + 0.50 * broi);
                    price = 0.5;
                }
                else if (product == "water")
                {
                    //Console.WriteLine(0.80 * broi);
                    price = 0.8;
                }
                else if (product == "beer")
                {
                    //Console.WriteLine("Total : " + 1.20 * broi);
                    price = 1.2;
                }
                else if (product == "sweets")
                {
                    //Console.WriteLine("Total : " + 1.45 * broi);
                    price = 1.45;
                }
                else if (product == "peanuts")
                {
                    //Console.WriteLine("Total : " + 1.50 * broi);
                    price = 1.5;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    //Console.WriteLine("Total : " + 0.50 * broi);
                    price = 0.45;
                }
                else if (product == "water")
                {
                    //Console.WriteLine(0.80 * broi);
                    price = 0.7;
                }
                else if (product == "beer")
                {
                    //Console.WriteLine("Total : " + 1.20 * broi);
                    price = 1.1;
                }
                else if (product == "sweets")
                {
                    //Console.WriteLine("Total : " + 1.45 * broi);
                    price = 1.35;
                }
                else if (product == "peanuts")
                {
                    //Console.WriteLine("Total : " + 1.50 * broi);
                    price = 1.55;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    //Console.WriteLine("Total : " + 0.50 * broi);
                    price = 0.4;
                }
                else if (product == "water")
                {
                    //Console.WriteLine(0.80 * broi);
                    price = 0.7;
                }
                else if (product == "beer")
                {
                    //Console.WriteLine("Total : " + 1.20 * broi);
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    //Console.WriteLine("Total : " + 1.45 * broi);
                    price = 1.30;
                }
                else if (product == "peanuts")
                {
                    //Console.WriteLine("Total : " + 1.50 * broi);
                    price = 1.5;
                }
            }
            Console.WriteLine("Total : " + price * broi);
        }
    }
}
