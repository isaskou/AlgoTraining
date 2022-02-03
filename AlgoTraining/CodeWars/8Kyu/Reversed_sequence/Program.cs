using System;
using System.Collections.Generic;

namespace Reversed_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build a function that returns an array of integers from n to 1 where n>0.

            //Example: n = 5-- > [5, 4, 3, 2, 1]

            int n = 5;
            Console.WriteLine(ReverseSeq(n));

            static int[] ReverseSeq(int n)
            {
                List<int> list = new List<int>();
                for (int i = n; i >0; i--)
                {
                    list.Add(i);
                }

                int[] response = list.ToArray();
                return response;
            }
        }
    }
}
