using System;

namespace Filter_out_the_geese
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string[] array = { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" };
            s.GooseFilter(array);

        }
    }
}
