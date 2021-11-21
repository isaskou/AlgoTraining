using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_divisors_of_a_number
{
    public class MySolution
    {
        public int Divisors(int n)
        {
            int cpt = 0;

            for (int diviseur = 1; diviseur <= n; diviseur++)
            {
                if (n % diviseur == 0) cpt++;
                else continue;
            }

            return cpt;
        }
    }
}
