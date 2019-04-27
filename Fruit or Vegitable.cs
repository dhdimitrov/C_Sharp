using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            if (product == "apple" || product == "banana" || product == "kiwi" || product == "chery" || product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }else if (product == "tomato" || product == "cucumber" || product == "peper" || product == "carrot")
            {
                Console.WriteLine("vegitable");
            }else Console.WriteLine("Unknown");
        }
    }
}
