using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> spisuk = Console.ReadLine().Split(' ').ToList();
            string comand = "start";
            while (comand != "END")
            {
                comand = Console.ReadLine();
                if(comand == "Add visitor")
                {
                    string addLast = Console.ReadLine();
                    spisuk.Add(addLast);
                }else if(comand == "Add visitor on position")
                {
                    string newVisitor = Console.ReadLine();
                    int addVisitor = int.Parse(Console.ReadLine());
                    spisuk.Insert(addVisitor, newVisitor);
                }else if(comand == "Remove visitor on position")
                {
                    int removeAt = int.Parse(Console.ReadLine());
                    spisuk.RemoveAt(removeAt);
                }
                else if (comand == "Remove last visitor")
                {
                    spisuk.RemoveAt(spisuk.Count - 1);
                }else if (comand == "Remove first visitor")
                {
                    spisuk.RemoveAt(0);
                }

            }

            Console.WriteLine(string.Join(",", spisuk));
        }
    }
}
