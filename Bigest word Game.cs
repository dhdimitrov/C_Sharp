using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            string duma = "strart";
            int result = 0;
            int wordScore = 0;
            string winner = "start";
            while (duma != "END OF GAME")
            {
                duma = Console.ReadLine();
                if (duma == "END OF GAME") break;
                int last = duma.Length;
                for (int i = 0; i <= last - 1; i++)
                {
                    wordScore += duma[i];
                }
                if(duma[0] > 'A' && duma[0] < 'Z')
                {
                    wordScore += 15;
                }
                if(duma[last - 1] == 't')
                {
                    wordScore += 20;
                }
                if(last >= 10)
                {
                    wordScore += 30;
                }

                if(wordScore > result)
                {
                    result = wordScore;
                    winner = duma;
                }
                wordScore = 0;
            }
            Console.WriteLine($"Winner is word: {winner}");
            Console.WriteLine($"Points: {result}");
        }
    }
}
