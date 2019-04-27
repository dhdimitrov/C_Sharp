using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = first + second + third;
            int minuti = 0;
            if(sum < 60)
            {
                minuti = 0;
            }else if (sum < 120)
            {
                minuti = 1;
                sum = sum - 60;
            }else
            {
                minuti = 2;
                sum = sum - 120;
            }
            if(sum < 10)
            {
                Console.WriteLine($"{minuti}:0{sum}");
            }
            else Console.WriteLine($"{minuti}:{sum}");

        }
    }
}
