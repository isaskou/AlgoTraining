using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_love_you__a_little___a_lot__passionately___not_at_all
{
    public class Solution
    {
        public string HowMuchILoveYou(int nb_petals)
        {
            string[] messages = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };
            string result = "";
            int cpt = 0;


            for (int i = 0; i < nb_petals; i++)
            {
                if (i >= messages.Length)
                {
                    if (cpt >= 6)
                    {
                        cpt = 0;
                    }
                    result = messages[cpt];
                    cpt++;

                }
                else { result = messages[i]; }

            }

            //Console.WriteLine(result);
            return result;
        }

    }
}
