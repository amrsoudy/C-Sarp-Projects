using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revExamenFinalPratique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produit> ar  =  new List<Produit>();

            ar.Add(new Produit("Bnb11","Bonbon",0.5));
            ar.Add(new Produit("pai22", "Pain", 1.75));
            ar.Add(new Produit("stl45", "Stylo", 1.5));
            ar.Add(new Produit("Tv78", "Television", 700.77));
            ar.Add(new Produit("Tbl97", "Bonbon", 0.5));


            var myobject = from item in ar
                           where (item.prix >= 0 && item.prix <= 234)
                           select item;

            foreach (var i in myobject) {

                Console.WriteLine(i);


            }


            Afficher(myobject);



        }

        private static void Afficher(IEnumerable<Produit> myobject)
        {
            foreach (var i in myobject)
            {

                Console.WriteLine(i);


            }
        }
    }
}
