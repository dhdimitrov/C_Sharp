using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputType = Console.ReadLine();
            string outputType = Console.ReadLine();

            double meters = 0;

            if (inputType == "km")
            {
                meters = value / 0.001;
            }
            else if (inputType == "mm")
            {
                meters = value / 1000;
            }
            else if (inputType == "cm")
            {
                meters = value / 100;
            }
            else if (inputType == "ml")
            {
                meters = value / 0.000621371192;
            }
            else if (inputType == "in")
            {
                meters = value / 39.3700787;
            }
            else if (inputType == "ft")
            {
                meters = value / 3.2808399;
            }
            else if (inputType == "yd")
            {
                meters = value / 1.0936133;
            }

            Console.WriteLine(meters);
        }
    }
}
