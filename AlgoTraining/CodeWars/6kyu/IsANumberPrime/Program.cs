using System;

namespace IsANumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //TESTCASE
            MySolution s = new MySolution();
            Console.WriteLine("Veuillez entrer un nombre");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"le nombre {input} est-il un nombre premier ? {s.IsPrime(input)}");

            Random random = new Random();
            int number = random.Next(int.MinValue, int.MaxValue);


            //Console.WriteLine($"le nombre max {input} est il un nombre premier ? {s.IsPrime(input)}");

            Console.WriteLine(BestSolution(input));

            static bool BestSolution(int n)
            {
                int sqrt = (int)Math.Sqrt(n);
                if (n <= 2 || n % 2 == 0) return n == 2;
                for (int i = 3; i <= sqrt; i += 2) if (n % i == 0) return false;
                return true;
            }

        }
    }
}
