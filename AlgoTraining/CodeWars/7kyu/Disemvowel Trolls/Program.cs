using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Disemvowel_Trolls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trolls are attacking your comment section!\n" +
                "A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.\n" +
                "Your task is to write a function that takes a string and return a new string with all vowels removed.");

            string div = "*******";

            #region MySolution
            #region TestMySolution
            Console.WriteLine(div);
            string str = "This website is for losers LOL!";

            Console.WriteLine(str);
            Console.WriteLine("result : {0}", Disemvowel(str));

            Console.WriteLine(div+"\n");
            #endregion
            static string Disemvowel(string str)
            {
                const string notAString = "Not a string.";
                const string zeroLength = "";

                string[] voyelToRemove = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

                if (str.GetType() != typeof(String)) return notAString;
                if (str.Length == 0) return zeroLength;
                else
                {
                    foreach (var item in voyelToRemove)
                    {
                        str = str.Replace(item, string.Empty);
                    }
                    return str;

                }
            }
            #endregion

            #region BestSolutions
            #region TestSolutions
            Console.WriteLine("Solution1 ");
            Console.WriteLine(str);
            Console.WriteLine("result : {0}", Solution1(str));

            Console.WriteLine(div + "\n");

            Console.WriteLine("Solution2 ");
            Console.WriteLine(str);
            Console.WriteLine("result : {0}", Solution2(str));

            Console.WriteLine(div + "\n");


            #endregion
            static string Solution1(string str)
            {
                return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
            }

            static string Solution2(string str)
            {
                string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
                for (int i = 0; i < vowels.Length; i++)
                {
                    str = str.Replace(vowels[i], "");
                }
                return str;
            }
            #endregion
        }
    }
}
