using System;
using System.Linq;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (var number in num)
            {
                Console.WriteLine(number);
            }
        }
    }
}
