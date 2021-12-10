using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chevaux_de_courses
{
    public class MySolution
    {
        public int Solution(int[] puissances)
        {
            Array.Sort(puissances);

            int result=int.MaxValue;
            int tempResult=int.MaxValue;

            for (int i = 1; i < puissances.Length; i++)
            {
                tempResult = puissances[i] - puissances[i - 1];
                if (tempResult <= result)
                {
                    result = tempResult;
                    if (result == 1)
                    {
                        break;
                        
                    }
                }
                else continue;
            }

            return result;
        }
    }
}
