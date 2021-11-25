using System;
using System.Collections.Generic;
using System.Linq;

namespace Who_likes_it
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //You probably know the "like" system from Facebook and other pages. People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.

            //Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the

            /*
            []                                -->  "no one likes this"
            ["Peter"]                         -->  "Peter likes this"
            ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
            ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
            ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
            */

            string divide = "**********\n";
            Console.WriteLine("Test My Solution");
            string[] name = { "Alex", "Jacob", "Isa", "Antoine", "Marc" };
            
            Console.WriteLine(Likes(name));

            Console.WriteLine(divide);

            Console.WriteLine("Test Best Solution");
            Console.WriteLine(Solution1(name));
            Console.WriteLine(divide);

            Console.WriteLine("test Best Solution2");
            Console.WriteLine(Solution2(name));
            Console.WriteLine(divide);

            static string Likes(string[] name)
            {
                string phrase = "";

                if (name.Length == 0) phrase = "no one likes this";
                if(name.Length ==1) phrase = name[0]+" likes this";
                if(name.Length==2) phrase=name[0]+ " and " +name[1] + " like this";
                if (name.Length == 3) phrase = name[0] + ", " + name[1] + " and " + name[2] + " like this";
                if(name.Length>=4)
                {
                    int numberOfPerson = name.Length - 2;
                    phrase= name[0] + ", " + name[1] + " and "+numberOfPerson+" others like this";
                }

                return phrase;
            }

            static string Solution1(string[] name)
            {
                switch (name.Length)
                {
                    case 0: return "no one likes this"; // :(
                    case 1: return $"{name[0]} likes this";
                    case 2: return $"{name[0]} and {name[1]} like this";
                    case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
                    default: return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
                }
            }

            static string Solution2(string[] name)
            {
                string[] pattern = { "no one likes this", "{0} likes this", "{0} and {1} like this", "{0}, {1} and {2} like this", "{0}, {1} and {2} others like this" };

                return name.Length < 4 ? string.Format(pattern[name.Length], name) : string.Format(pattern[4], name[0], name[1], name.Length - 2);
            }

            Console.WriteLine("test Best Solution3");
            Console.WriteLine(Solution3(name));
            Console.WriteLine(divide);



            //ternaire sur plusieurs solutions
            static string Solution3(string[] names)
            {
                string likes = " likes this";
                string like = " like this";
                int amount = names.Length;
                return amount == 0 ? $"no one{likes}" :
                       amount == 1 ? $"{names[0]}{likes}" :
                       amount == 2 ? $"{names[0]} and {names[1]}{like}" :
                       amount == 3 ? $"{names[0]}, {names[1]} and {names[2]}{like}" :
                                     $"{names[0]}, {names[1]} and {amount - 2} others{like}";
            }
        }
    }
}
