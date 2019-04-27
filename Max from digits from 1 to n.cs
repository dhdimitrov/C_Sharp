using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxnum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > maxnum)
                {
                    maxnum = current;
                }
            }
            Console.WriteLine(maxnum);
        }
    }
}
