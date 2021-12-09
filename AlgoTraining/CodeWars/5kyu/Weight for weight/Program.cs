using System;

namespace Weight_for_weight
{
    class Program
    {
        static void Main(string[] args)
        {
            MySolution s = new MySolution();
            string input = Console.ReadLine();
            
            Console.WriteLine(s.orderWeight(input));

            

        }
    }
}
