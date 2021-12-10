using System;
using System.Linq;

namespace Weight_for_weight
{
    class Program
    {
        static void Main(string[] args)
        {
            MySolution s = new MySolution();
            string input = Console.ReadLine();
            
            Console.WriteLine(s.orderWeight(input));


            static string BestSolution1(string s)
            {
                return string.Join(" ", s.Split(' ')
                            .OrderBy(n => n.ToCharArray()
                            .Select(c => (int)char.GetNumericValue(c)).Sum())
                            .ThenBy(n => n));
            }


            

        }
    }
}
