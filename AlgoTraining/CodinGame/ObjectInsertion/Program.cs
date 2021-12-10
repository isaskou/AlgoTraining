using System;

namespace ObjectInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int rows = int.Parse(inputs[0]);
            int columns = int.Parse(inputs[1]);

            ////mettre ça dans un tableau
            //string[,] tableau1 = new string[a,b];
            //int j = 0;
            //for (int i = 0; i < a; i++)
            //{
            //    string objectLine = Console.ReadLine();
            //    char[] characters = objectLine.ToCharArray();
            //    foreach (var item in characters)
            //    {
            //        tableau1[i,j]=tableau1
            //    }

            //}

            testTableau2D t = new testTableau2D();
            string[,] tableau = new string[rows, columns]; //rangées,colonnes

            t.test(tableau);

            //inputs = Console.ReadLine().Split(' ');
            //int c = int.Parse(inputs[0]);
            //int d = int.Parse(inputs[1]);

            ////mettre ça dans un tableau
            //string[] tableau2 = new string[c];
            //for (int i = 0; i < c; i++)
            //{
            //    string gridLine = Console.ReadLine();
            //    tableau2[i] = gridLine;
            //}


            ////J'ai mes 2 tableaux, je dois vérifier chacune des itérations
            //bool isSpace;
            ////vérifier que la 1ère ligne du tableau 2
            //for (int i = 0; i < tableau2.Length; i+=b)
            //{
            //    if (tableau2[i].Contains('.'))
            //    {
            //        i++;
            //    }
            //}


            //// Write an answer using Console.WriteLine()
            //// To debug: Console.Error.WriteLine("Debug messages...");

            //Console.WriteLine("answer");
        }
    }
}
