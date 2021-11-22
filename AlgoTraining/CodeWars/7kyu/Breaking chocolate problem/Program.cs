using System;

namespace Breaking_chocolate_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            #region MySolution
            string div = "********";
            #region TestMySolution
            int n = 2;
            int m = 1;
            Console.WriteLine("n = {0} - m = {1} - number of split = {2}", n, m, BreakChocolate(n,m));
            Console.WriteLine(div+"\n");

            n = 5;m = 5;
            Console.WriteLine("n = {0} - m = {1} - number of split = {2}", n, m, BreakChocolate(n, m));
            Console.WriteLine(div);

            #endregion

            static int BreakChocolate(int n, int m)
            {
                //int result = (n * m) - 1;
                //if (result < 0) return 0;
                //else return result;
                return ((n * m) - 1) < 0 ? 0 : ((n * m) - 1);
            }
            #endregion

            #region BestSolutions

            #region testBestSolution
            Console.WriteLine("Solution1");
            Console.WriteLine("n = {0} - m = {1} - number of split = {2}", n, m, Solution1(n, m));
            Console.WriteLine(div);

            Console.WriteLine("Solution2");
            Console.WriteLine("n = {0} - m = {1} - number of split = {2}", n, m, Solution2(n, m));
            Console.WriteLine(div);


            #endregion
            static int Solution1(int a, int b)
            {
                //same as me but in different way
                return a * b > 0 ? a * b - 1 : 0;
            }

            static int Solution2(int n, int m)
            {
                //return the biggest between de 0 and n*m-1
                return Math.Max(0, n * m - 1);
            }
            #endregion
        }
    }
}
