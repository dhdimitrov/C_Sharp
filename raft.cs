using System;
using System.Linq;


namespace raft
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string[] values = S.Split(' ');
            int N = int.Parse(values[0]);
            int K = int.Parse(values[1]);

            string goatCounter = Console.ReadLine();
            string[] goats = goatCounter.Split(' ');
            int[] Weight = Array.ConvertAll(goats, int.Parse);

            Array.Sort(Weight);
            Array.Reverse(Weight);

            int Const = 0;
            for (int i = 0; i < Weight.Count(); i++)
            {
                Const += Weight[i];
            }

            Const /= K;

            int Sum = 0;
            for (int i = 0; i < K; i++)
            {
                Sum = 0;
                for (int k = 0; k < Weight.Count(); k++)
                {

                    if(Sum + Weight[k] <= Const)
                    {
                        Sum += Weight[k];
                        Weight = Weight.Where((source, index) => index != k).ToArray();
                        k = -1;
                    }
                    if (Sum == Const)
                        break;
                }
            }
            if(Weight.Count() != 0)
            {
                Const = Sum + Weight[0];
            }
            Console.WriteLine(Const);
        }
    }
}
