using System;
using System.Globalization;
using System.Linq;

namespace Jaden_Casing_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "How can mirrors be real if our eyes aren't real";
            string divide = "*********";
            Console.WriteLine("Phrase initiale : {0}", phrase);

            Console.WriteLine(divide);

            Console.WriteLine("My solution : ");
            MySolution s = new MySolution();
            Console.WriteLine(s.ToJadenCase(phrase));

            Console.WriteLine(divide);
            Console.WriteLine("Best Practice 1");
            Console.WriteLine(ToJadenCase_Solution1(phrase));

            Console.WriteLine(divide);
            Console.WriteLine("Best Practice 2");
            Console.WriteLine(ToJadenCase_Solution2(phrase));

            static string ToJadenCase_Solution1(string phrase)
            {
                return String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1)));
            }

            static string ToJadenCase_Solution2(string phrase)
            {
                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            }




        }
    }
}
