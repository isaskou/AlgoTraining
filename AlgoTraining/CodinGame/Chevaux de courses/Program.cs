using System;
using System.Collections.Generic;

namespace Chevaux_de_courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region MySolution
            //int nombreChevaux = int.Parse(Console.ReadLine());
            //List<int> listePuissance = new List<int>();

            //for (int i = 0; i < nombreChevaux; i++)
            //{
            //    int puissanceCheval = int.Parse(Console.ReadLine());
            //    listePuissance.Add(puissanceCheval);
            //}

            //int[] powerArray = listePuissance.ToArray();
            //MySolution s = new MySolution();
            //Console.WriteLine(s.Solution(powerArray)); 
            #endregion

            #region BestSolution


            int N = int.Parse(Console.ReadLine());
            List<int> horses = new List<int>();
            for (int i = 0; i < N; i++)
            {
                horses.Add(int.Parse(Console.ReadLine()));
            }

            BestSolution1(horses);

            void BestSolution1(List<int> power)
            {
                horses.Sort();
                int best = horses[horses.Count - 1];
                int last = 0;
                for (var i = 0; i < horses.Count; i++)
                {
                    if (best > (horses[i] - last))
                    {
                        best = horses[i] - last;
                    }
                    last = horses[i];
                }

                Console.WriteLine(best.ToString());
            }
            
            #endregion


        }
    }
}
