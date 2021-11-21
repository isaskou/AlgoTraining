using System;
using System.Linq;

namespace Difference_Volumes_of_Cuboids
{
    class Program
    {
        static void Main(string[] args)
        {
            //In this simple exercise, you will create a program that will take two lists of integers, a and b. Each list will consist of 3 positive integers above 0, representing the dimensions of cuboids a and b. You must find the difference of the cuboids' volumes regardless of which is bigger.

            //In this simple exercise, you will create a program that will take two lists of integers, a and b. Each list will consist of 3 positive integers above 0, representing the dimensions of cuboids a and b. You must find the difference of the cuboids' volumes regardless of which is bigger.
            string div = "********";
            MySolution s = new MySolution();
            int[] A = new int[] { 2, 2, 3 };
            int[] B = new int[] { 5, 4, 1 };

            Console.WriteLine("My Solution");
            Console.WriteLine(s.FindDifference(A, B)); ;
            Console.WriteLine(div);

            Console.WriteLine("Solution 1");
            Console.WriteLine(FindDifference1(A, B));
            Console.WriteLine(div);

            Console.WriteLine("Solution 2");
            Console.WriteLine(FindDifference2(A, B));
            Console.WriteLine(div);

            //Different Solutions

            static int FindDifference1(int[] a, int[] b)
            {
                return Math.Abs((a[0] * a[1] * a[2]) - (b[0] * b[1] * b[2])); // return the absulute value difference between cube volume
            }

            static int FindDifference2(int[] a, int[] b)
            {
                return (int)Math.Abs(a.Aggregate((vol, x) => vol * x) - b.Aggregate((vol, y) => vol * y));
            }
        }
    }
}
