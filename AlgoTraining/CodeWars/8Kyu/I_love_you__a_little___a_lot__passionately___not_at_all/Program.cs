using System;

namespace I_love_you__a_little___a_lot__passionately___not_at_all
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Solution s = new Solution();
            //s.HowMuchILoveYou(142);
            Console.WriteLine("*******");
            HowMuchILoveYou(7);
            //HowMuchILoveYou(3);
            //HowMuchILoveYou(10);
            //HowMuchILoveYou(6);
            HowMuchILoveYou(14);

            static string HowMuchILoveYou(int nb_petals)
            {
                string[] messages = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };
                int count = 0;
                for (int i = 0; i < nb_petals; i++)
                {
                    count++;
                    if (count > 6) count = 1;
                }

                Console.WriteLine(messages[count - 1]);
                return messages[count - 1];
            }
        }
    }
}
