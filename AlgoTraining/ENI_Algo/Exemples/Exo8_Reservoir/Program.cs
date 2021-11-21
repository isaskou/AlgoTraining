using System;

namespace Exo8_Reservoir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exo8_reservoir");

            //établir la liste des opérations pertinentes applicables à un réservoir

            //voir classe Reservoire
            string divide = "*********";

            Reservoir r = new Reservoir();
            r.capacite = 1000;
            r.contenance = 0;
            Console.WriteLine("capacité initale : {0} \n contenance initiale : {1}", r.capacite, r.contenance);

            Console.WriteLine("est rempli : " + r.estRempli);
            Console.WriteLine("est vide : " + r.estVide);

            Console.WriteLine(divide);

            r.Remplir();
            Console.WriteLine("methode remplir");
            Console.WriteLine("est rempli : " + r.estRempli);
            Console.WriteLine("est vide : " + r.estVide);

            Console.WriteLine(divide);

            r.Vider();
            Console.WriteLine("méthode vider");
            Console.WriteLine("est rempli : " + r.estRempli);
            Console.WriteLine("est vide : " + r.estVide);

            Console.WriteLine(divide);

            r.Ajouter(500);
            Console.WriteLine("méthode ajouter");
            Console.WriteLine("est rempli : " + r.estRempli);
            Console.WriteLine("est vide : " + r.estVide);
            Console.WriteLine("capacité : {0}L", r.capacite);
            Console.WriteLine("contenance : {0}L", r.contenance);

            Console.WriteLine(divide);
            r.Enlever(250);
            Console.WriteLine("méthode enlever");
            Console.WriteLine("est rempli : " + r.estRempli);
            Console.WriteLine("est vide : " + r.estVide);
            Console.WriteLine("capacité : {0}L", r.capacite);
            Console.WriteLine("contenance : {0}L", r.contenance);

            Console.WriteLine(divide);
            Console.WriteLine("test des erreurs possibles");

            Console.WriteLine("enlever 500");
            r.Enlever(500);
            Console.WriteLine("capacité : {0}L", r.capacite);
            Console.WriteLine("contenance : {0}L", r.contenance);


            Console.WriteLine("ajouter 1500");
            r.Ajouter(1500);
            Console.WriteLine("capacité : {0}L", r.capacite);
            Console.WriteLine("contenance : {0}L", r.contenance);


            Console.WriteLine(divide);
            Console.WriteLine("est rempli : " + r.estRempli);
            Console.WriteLine("est vide : " + r.estVide);
            Console.WriteLine("capacité : {0}L", r.capacite);
            Console.WriteLine("contenance : {0}L", r.contenance);


            Console.WriteLine(divide);
            Console.WriteLine("remplir");
            r.Remplir();
            Console.WriteLine("est rempli : " + r.estRempli);
            Console.WriteLine("est vide : " + r.estVide);
            Console.WriteLine("capacité : {0}L", r.capacite);
            Console.WriteLine("contenance : {0}L", r.contenance);

            Console.WriteLine(divide);
            Console.WriteLine("vider");
            r.Vider();
            Console.WriteLine("est rempli : " + r.estRempli);
            Console.WriteLine("est vide : " + r.estVide);
            Console.WriteLine("capacité : {0}L", r.capacite);
            Console.WriteLine("contenance : {0}L", r.contenance);


        }
    }
}
