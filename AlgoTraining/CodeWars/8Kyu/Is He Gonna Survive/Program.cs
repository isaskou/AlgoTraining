using System;

namespace Is_He_Gonna_Survive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestCase");
            Console.WriteLine(Hero(10, 5));
            Console.WriteLine("TestCase2");
            Console.WriteLine(Hero(7, 4));
            Console.WriteLine("TestCase3");
            Console.WriteLine(Hero(0, 1));
            Console.WriteLine("TestCase3");
            Console.WriteLine(Hero(100, 40));


            static bool Hero(int bullets, int dragons)
            {
                return (dragons * 2) > bullets ? false : true;
            }
        }
    }
}
