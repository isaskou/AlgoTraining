using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaden_Casing_Strings
{
    public class MySolution
    {
        public string ToJadenCase(string phrase)
        {
            List<string> array = phrase.Split(' ').ToList();
            string newWord = "";
            List<string> newSentence = new List<string>();

            foreach (var item in array)
            {
                newWord = item[0].ToString().ToUpper() + item.Substring(1).ToLower();
                newSentence.Add(newWord);
            }

            return string.Join(" ", newSentence);

        }
    }
}
