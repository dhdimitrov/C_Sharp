using System;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] num = new int[length];

            for (int i = 0; i < length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
