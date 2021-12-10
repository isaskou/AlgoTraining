using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBreakerPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ALPHABET = Console.ReadLine();
            ////ABCDEFGHIJKLMNOPQRSTUVWXYZ_
            //string MESSAGE = Console.ReadLine();
            ////IFMMPAXPSME
            //string WORD = Console.ReadLine();
            ////XPSME
            ////+1/+1/+1/+1/+1
            ////WORLD
            ///

            MySolution s = new MySolution();
            Console.WriteLine("result = {0}", s.test("abc", "IFMMPAXPSME","WORLD"));



            //Sortie = Hello_World

            // static string test(string alphabet, string message, string word)
            //{
            //    string result = "";
            //    //(X+A)%L
            //    //X=Lettre
            //    //A=décalage = +1
            //    //L=longueur alphabet

            //    List<string> letters = word.ToCharArray().Select(x => x.ToString()).ToList();
            //    List<string> alphabets = alphabet.ToCharArray().Select(x => x.ToString()).ToList();
            //    for (int i = 0; i < alphabet.Length; i++)
            //    {
            //        result[i] = alphabet[i+1];
            //    }


            //    return result;
            //}

            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

        }
    }
}
