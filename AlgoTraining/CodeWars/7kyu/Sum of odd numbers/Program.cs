using System;
using System.Collections.Generic;

namespace Sum_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //REUSSI ! 

            //Given the triangle of consecutive odd numbers:

            //Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)
            //1 -->  1
            //2-- > 3 + 5 = 8

            #region test

            long n;
            string div = "******";
            n = 1;
            Console.WriteLine("N = {0} -> {1}", n, rowSumOddNumbers(n));
            Console.WriteLine(div);
            Console.WriteLine("");

            n = 2;
            Console.WriteLine("N = {0} -> {1}", n, rowSumOddNumbers(n));
            Console.WriteLine(div);
            Console.WriteLine("");

            n = 42;
            Console.WriteLine("N = {0} -> {1}", n, rowSumOddNumbers(n));
            Console.WriteLine(div);
            Console.WriteLine("");

            Console.WriteLine("Test Random");
            Random r = new Random();
            n = r.Next(250, 500);
            
            Console.WriteLine("N = {0} -> {1}", n, rowSumOddNumbers(n));
            Console.WriteLine(div);
            Console.WriteLine("");

            #endregion

            static long rowSumOddNumbers(long n)
            {
                //Math Pow permet de définir la puissance de n
                // Attention, il faut caster si n n'est pas un double
                return (long)Math.Pow(n, 3);
            }
        }
    }
}
