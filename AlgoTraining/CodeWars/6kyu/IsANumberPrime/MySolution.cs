using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsANumberPrime
{
    public class MySolution
    {
        public bool IsPrime(int n)
        {
            
            if (n < 1) return false;
            if (n == 2 || n == 3 || n == 5 || n == 7) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            else
            {
                int i = 5;
                while (i <= Math.Sqrt(n))
                {
                    if (n % i == 0 || n % (i + 2) == 0) return false;
                    else i += 6;
                }
                return true;
            }
        }
    }
}
