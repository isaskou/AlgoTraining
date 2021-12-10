using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInsertion
{
    public class testTableau2D
    {
        
        //remplir le tableau

        public void test(string[,] tab)
        {
            int tailleLigne = tab.GetLength(0);//A
            int tailleColonne = tab.GetLength(1);//B

            char[] characters = new char[tailleColonne];
            string objectLine = Console.ReadLine();

            for (int ligne = 0; ligne < tailleLigne; ligne++)
            {
                for (int colonne = 0; colonne < tailleColonne; colonne++)
                {

                    //on remplit le tableau de char
                    for (int i = 0; i < characters.Length; i++)
                    {
                        characters[i] = objectLine[i];
                        //Console.WriteLine(characters[i]);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
