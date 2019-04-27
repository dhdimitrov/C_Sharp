using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            if (word1 == word2)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
}
