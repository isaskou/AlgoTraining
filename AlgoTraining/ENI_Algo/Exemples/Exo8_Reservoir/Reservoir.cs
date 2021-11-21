using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo8_Reservoir
{
    public class Reservoir
    {
        public double capacite { get; set; }
        public double contenance { get; set; }
        private bool _estVide;

        public bool estVide
        {
            get
            {
                if (contenance == 0) return true;
                else return false;
            }
            set { _estVide = value; }
        }


        private bool _estRempli;

        public bool estRempli
        {
            get
            {
                if (contenance == capacite) return true;
                else return false;
            }
            set { _estRempli = value; }
        }


        public void Vider()
        {
            if (estVide == false)
            {
                contenance = 0;
                estVide = true;
            }
            else
            {
                Console.WriteLine("c'est déjà vide");
            }
        }
        public void Remplir()
        {
            if (estRempli == false)
            {
                contenance = capacite;
                estRempli = true;
            }
            else
            {
                Console.WriteLine("c'est déjà rempli ! ");
            }
        }
        public void Ajouter(double a)
        {
            if (estRempli == true) Console.WriteLine("impossible d'ajouter");

            if ((contenance + a) > capacite) Console.WriteLine("ça va déborder");

            else
            {
                contenance = contenance + a;
            }

        }
        public void Enlever(double b)
        {
            if (estVide == true) Console.WriteLine("impossible d'enlever");
            if ((contenance - b) < 0) Console.WriteLine("c'est bientôt vide");

            else
            {
                contenance = contenance - b;
            }
        }
    }
}

