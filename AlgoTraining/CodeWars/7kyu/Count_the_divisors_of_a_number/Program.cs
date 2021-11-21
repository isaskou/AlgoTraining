using System;

namespace Count_the_divisors_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            MySolution s = new MySolution();

            int cpt = 1;
            string divide = "*******";
            Console.WriteLine("test" + cpt);
            Console.WriteLine(4);
            Console.WriteLine("response : ");
            Console.WriteLine(s.Divisors(30));
            Console.WriteLine(divide);
            cpt += 1;

        }
    }
}
