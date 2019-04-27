using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) { Console.WriteLine("The num is even!!!"); }
            else { Console.WriteLine("The num is odd"); }

        }
    }
}
