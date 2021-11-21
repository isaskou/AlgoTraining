using System;

namespace Exo7_Echanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exo7");

            Console.WriteLine("My Solution");

            Echanger(10, 20);
            Console.WriteLine("*********");

            Console.WriteLine("SolutionEni");

            Echanger2(10, 20);

            static void Echanger(int a, int b)
            {
                Console.WriteLine("variable initiales : var1={0}, var2={1}", a, b);

                int varTemp = a;
                a = b;
                b = varTemp;

                Console.WriteLine("echanges des valeurs :  var1={0}, var2={1}", a, b);

            }

            static void Echanger2(int a, int b)
            {
                Console.WriteLine("variable initiales : var1={0}, var2={1}", a, b);

                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("echanges des valeurs :  var1={0}, var2={1}", a, b);

            }
        }
    }
}
