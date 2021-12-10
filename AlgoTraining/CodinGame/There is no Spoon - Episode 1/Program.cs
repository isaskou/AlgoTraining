using System;
using System.Collections.Generic;
using System.Linq;

namespace There_is_no_Spoon___Episode_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine()); // the number of cells on the X axis //largeur grille
            int height = int.Parse(Console.ReadLine()); // the number of cells on the Y axis //hauteur grille

            List<string> listLigne = new List<string>();

            for (int i = 0; i < height; i++)
            {
                string line = Console.ReadLine(); // width characters, each either 0 = noeud or . = vide 
                
                listLigne.Add(line);
            
            }
            List<char> letters = new List<char>();

            int x = 0;
            int y = 0;
            int ligne = 0;

            List<string> result = new List<string>();

            

            foreach (var item in listLigne) //item est la ligne
            {
                
                letters = item.ToList(); //met la ligne dans le char[] 
                for (int i = 0; i < letters.Count; i++)
                {
                    if (letters[i] == '0')
                    {
                        x = i;
                        result.Add(x.ToString());
                        y = ligne;
                        result.Add(y.ToString());

                        //if(i == letters.Count - 1)
                        //{
                        //    result.Add("-1");
                        //}
                        
                    }
                }
                ligne++;
            }

            string response = "";
            for (int i = 0; i < result.Count; i++)
            {
                response += result[i] + " ";
            }
            Console.WriteLine(response);

            
            

        }
    }
}
