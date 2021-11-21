using System;

namespace Exo8_TVA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice 8 : Taux, TVA et placements");
            //1. Écrire un algorithme qui calcule le prix toute taxe comprise (TTC) pour un prix hors taxe et un taux de TVA donné.
            //2. Écrire un algorithme qui calcule le montant des intérêts rapportés par un capital placé à un taux donné pendant une durée donnée, exprimée en mois.

            string div = "*********";
            #region Test1

            Console.WriteLine("test calculTTC");
            double prixHT = 100;
            int tva = 21;

            Console.WriteLine("montant HT : {0} \n tva : {1}", prixHT, tva);

            Console.WriteLine("montant TVAC : {0}", CalculTTC(prixHT, tva));
            Console.WriteLine(div);

            prixHT = 0;
            tva = 6;
            Console.WriteLine("montant HT : {0} \n tva : {1}", prixHT, tva);

            Console.WriteLine("montant TVAC : {0}", CalculTTC(prixHT, tva));
            Console.WriteLine(div);

            prixHT = 100;
            tva = 0;
            Console.WriteLine("montant HT : {0} \n tva : {1}", prixHT, tva);

            Console.WriteLine("montant TVAC : {0}", CalculTTC(prixHT, tva));
            Console.WriteLine(div);

            #endregion

            #region Test2
            Console.WriteLine("TEST Placements");

            double capital = 100;
            int taux = 10;
            int duree = 12;

            Console.WriteLine("capital : {0} €\n taux : {1} %\n duree : {2} mois", capital, taux, duree);
            Console.WriteLine("montant des intérêts : {0} €/mois", CalculInterets(capital, taux, duree));
            Console.WriteLine(div);

            capital = 0;
            taux = 10;
            duree = 12;

            Console.WriteLine("capital : {0} €\n taux : {1} %\n duree : {2} mois", capital, taux, duree);
            Console.WriteLine("montant des intérêts : {0} €/mois", CalculInterets(capital, taux, duree));
            Console.WriteLine(div);

            capital = 100;
            taux = 0;
            duree = 12;

            Console.WriteLine("capital : {0} €\n taux : {1} %\n duree : {2} mois", capital, taux, duree);
            Console.WriteLine("montant des intérêts : {0} €/mois", CalculInterets(capital, taux, duree));
            Console.WriteLine(div);

            capital = 100;
            taux = 10;
            duree = 0;

            Console.WriteLine("capital : {0} €\n taux : {1} %\n duree : {2} mois", capital, taux, duree);
            Console.WriteLine("montant des intérêts : {0} €/mois", CalculInterets(capital, taux, duree));
            Console.WriteLine(div);


            #endregion

            #region 1

            static double CalculTTC(double prixHT, int tva)
            {
                if (prixHT < 0 || tva < 0)
                {
                    Console.WriteLine("impossible de calculer le montant htva");
                    return double.NaN;
                }

                else
                {
                    return prixHT + (prixHT * tva / 100);
                }
            }

            #endregion

            #region 2
            static double CalculInterets(double capital, int taux, int duree)
            {
                double interet = capital / taux * duree;

                if (duree <= 0) Console.WriteLine("la durée est trop courte");
                if (taux <= 0)
                {
                    Console.WriteLine("le taux est trop bas");
                    return double.NaN;
                }

                if (capital <= 0) Console.WriteLine("pas de capital");


                return interet;
            }
            #endregion


        }
    }
}
