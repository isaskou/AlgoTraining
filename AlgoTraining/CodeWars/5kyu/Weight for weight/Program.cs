using System;

namespace Weight_for_weight
{
    class Program
    {
        static void Main(string[] args)
        {
            MySolution s = new MySolution();
            Console.WriteLine(s.orderWeight(null));

            int x, y, temp;

            x = 10;
            y = 5;
            Console.WriteLine("x={0} - y={1}", x, y);

            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("x={0} - y={1}", x, y);

        }
    }
}
