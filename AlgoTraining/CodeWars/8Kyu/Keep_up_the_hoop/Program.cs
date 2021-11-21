using System;

namespace Keep_up_the_hoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string div = "*******";
            Solution s = new Solution();

            Console.WriteLine("My Solution");

            Console.WriteLine(s.HoopCount(34));

            Console.WriteLine(div);

            Console.WriteLine("Best Solution");

            Console.WriteLine(s.HoopCount(34));

            static string HoopCount(int n)
            {
                return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
            }

        }
    }
}
