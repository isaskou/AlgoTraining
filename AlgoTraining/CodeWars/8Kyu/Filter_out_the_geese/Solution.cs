using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter_out_the_geese
{
    public class Solution
    {
        public IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            return birds.Except(geese).ToList();

            //return newList;
        }
    }
}
