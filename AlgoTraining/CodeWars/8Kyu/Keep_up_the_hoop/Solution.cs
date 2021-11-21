using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_up_the_hoop
{
    public class Solution
    {
        public string HoopCount(int n)
        {
            if (n >= 10)
            {
                return "Great, now move on to tricks";
            }
            else
            {
                return "Keep at it until you get it";
            }
        }

    }
}
