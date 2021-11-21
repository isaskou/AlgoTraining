using System;

namespace Waiting_room
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int chairs = 10;
            Console.WriteLine(LastChair(chairs));

            static int LastChair(int n)
            {
                return n - 1;

            }
        }
    }
}
