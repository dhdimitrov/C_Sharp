using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <= 100)
            {
                bonus = bonus + 5;
            }else if (num <= 1000)
            {
                bonus = num / 5;
            }else if (num > 1000)
            {
                bonus = num / 10;
            }

            if (num % 2 == 0)
            {
                bonus++;
            }else if (num % 10 == 5)
            {
                bonus = bonus + 2; 
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus + num);
        }
    }
}
