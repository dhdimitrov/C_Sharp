using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "1234";
            string guess = Console.ReadLine();
            if(password == guess)
            {
                Console.WriteLine("Yes");
            }else Console.WriteLine("No");
        }
    }
}
