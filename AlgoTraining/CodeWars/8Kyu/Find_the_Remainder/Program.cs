using System;

namespace Find_the_Remainder
{
    class Program
    {
        //Write a function that accepts two arguments and returns the remainder after dividing the larger number by the smaller number.

        //Division by zero should return NaN. 

        //Divison by zero should throw a new DivideByZeroException.
        static void Main(string[] args)
        {
            string divide = "********";
            //test
            Console.WriteLine(Remainder(17, 5));
            Console.WriteLine(divide);
            Console.WriteLine(Remainder(13, 72));
            Console.WriteLine(divide);
            Console.WriteLine(Remainder(1, 0));
            Console.WriteLine(divide);
            Console.WriteLine(Remainder(0, 0));


            //Mysolution
            static int Remainder(int a, int b)
            {
                if (a == 0 || b == 0) throw new DivideByZeroException();
                return a > b ? a % b : b % a;
            }


        }
    }
}
