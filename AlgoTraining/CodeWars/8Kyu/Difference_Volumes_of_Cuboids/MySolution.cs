using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Volumes_of_Cuboids
{
    public class MySolution
    {
        public int FindDifference(int[] a, int[] b)
        {
            int resultA = a[0] * a[1] * a[2];

            int resultB = b[0] * b[1] * b[2];

            int difference = resultB - resultA;


            if (resultA > resultB) difference = resultA - resultB;


            return difference;
        }

    }
}
