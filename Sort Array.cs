using System;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, -1, 3, 2, 9, -15 };

            Array.Sort(arr);
            //Array.Reverse(arr);
            Console.WriteLine(string.Join(",", arr));
        }
    }
}
