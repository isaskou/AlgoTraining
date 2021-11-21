using System;

namespace DNA_to_RNA_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dna = "GCAT";
            dnaToRna(dna);


            static string dnaToRna(string dna) => dna.Replace("T", "U");
            //{
            //    string rna = dna.Replace("T", "U");

            //    return rna;
            //    //if (dna.Contains("T"))
            //    //{
            //    //    rna.Replace("T", "U");
            //    //}
            //    //return rna;
            //}
        }
    }
}
