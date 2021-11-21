using System;

namespace NBA_full_48_minutes_average
{
    class Program
    {
        static void Main(string[] args)
        {
            //An NBA game runs 48 minutes (Four 12 minute quarters). Players do not typically play the full game, subbing in and out as necessary. Your job is to extrapolate a player's points per game if they played the full 48 minutes.

            //Write a function that takes two arguments, ppg(points per game) and mpg(minutes per game) and returns a straight extrapolation of ppg per 48 minutes rounded to the nearest tenth. Return 0 if 0.

            //All inputs will be either be an integer or float.
            //Follow your dreams!

            //test
            string divide = "*******";
            Console.WriteLine(NbaExtrap(12, 20));
            Console.WriteLine(divide);
            Console.WriteLine(NbaExtrap(10, 10));
            Console.WriteLine(divide);
            Console.WriteLine(NbaExtrap(5, 17));
            Console.WriteLine(divide);
            Console.WriteLine(NbaExtrap(0, 0));

            static double NbaExtrap(double ppg, double mpg)
            {
                //double result = (ppg * 48) / mpg;
                double result = Math.Round((ppg * 48) / mpg, 1);

                return ppg == 0 || mpg == 0 ? 0 : result;
                //if (ppg == 0 || mpg == 0) return 0;
                //else return result;

            }
        }
    }
}
