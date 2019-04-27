using System;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, -1, 3, 2, 9, -15 };

            Array.Clear(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
