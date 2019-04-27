using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            string ured;
            double cena = 0;
            for (int i = 0; i < broi; i++)
            {
                ured = Console.ReadLine();
                if(ured == "treadmill")
                {
                    cena += 5899;
                }else if (ured == "cross trainer")
                {
                    cena += 1699;
                }else if (ured == "exercise bike")
                {
                    cena += 1789;
                }else if (ured == "dumbbells")
                {
                    cena += 579;
                }
            }
            Console.WriteLine(cena);
        }
    }
}
