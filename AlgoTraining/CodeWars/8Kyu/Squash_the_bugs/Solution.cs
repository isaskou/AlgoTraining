using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squash_the_bugs
{
    public class Solution
    {
        public int FindLongest(string str)
        {
            var spl = str.Split(" ");
            var longest = 0;

            for (var i = 0; i < spl.Length; i++)
            {
                if (spl[i].Length > longest)
                {
                    longest = spl[i].Length;
                }
            }
            return longest;
        }



    }
}
