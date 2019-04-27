using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int add = minute + 15;
            if (add >= 60)
            {
                hour ++;
                add = add - 60;

            }
            if (hour >= 24)
                hour = hour - 24;
            Console.WriteLine($"The time in 15 minutes will be {hour}:{add}");
        }
    }
}
