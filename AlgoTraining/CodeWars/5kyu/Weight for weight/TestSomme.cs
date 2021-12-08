using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weight_for_weight
{
    public class TestSomme
    {

        public int Test(int number)
        {
            int sum = 0;
            int temp;

            do
            {
                temp = number % 10;
                sum = sum + temp;
                number = number / 10;
            } while (number!=0);

            return sum;

        }
    }
}
