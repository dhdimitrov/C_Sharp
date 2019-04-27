using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price;
            if(km < 20)
            {
                if(time == "day")
                {
                    price = 0.79 * km + 0.70;

                }
                else
                {
                    price = 0.90 * km + 0.70;
                }
            }else if(km < 100)
            {
                price = 0.9 * km;
            }
            else
            {
                price = 0.6 * km;
            }
            Console.WriteLine(price);
        }
    }
}
