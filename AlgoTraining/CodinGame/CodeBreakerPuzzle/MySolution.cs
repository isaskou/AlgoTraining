using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBreakerPuzzle
{
    public class MySolution
    {
        public string test(string alphabet, string message, string word)
        {
            string result = "";
            //(X+A)%L
            //X=Lettre
            //A=décalage = +1
            //L=longueur alphabet

            alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ_";
            message = "IFMMPAXPSME";
            word = "WORLD";

            int numberOfLetter = word.Length;
            result = message.Substring(message.Length - numberOfLetter);

            //Console.WriteLine(result);




            return result;
        }
    }
}
