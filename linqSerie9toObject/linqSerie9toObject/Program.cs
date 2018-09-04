using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqSerie9toObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] list = { 2, 9, 5, 0, 3, 7, 1, 4, 8, 5 };



            //var res = from i in list where i > 4 orderby i select i;
            //// var res = from i in list where i > 4 orderby i descending select i;




            ////foreach (int f in res) {

            ////    Console.WriteLine(f.ToString());


            ////}

            //AffichageDonnees(res, "x");

            //List<Employe> ListEmp = new List<Employe>();
            //ListEmp.Add(new Employe("jason", "Red", 5000));
            //ListEmp.Add(new Employe("Ashley", "Green", 7600));
            //ListEmp.Add(new Employe("Matthew", "Indigo", 3587.5));
            //ListEmp.Add(new Employe("James", "Indigo", 4700.77));
            //ListEmp.Add(new Employe("Luke", "Indigo", 6200));
            //ListEmp.Add(new Employe("Jason", "Blue", 3200));
            //ListEmp.Add(new Employe("Wendy", "Brown", 4236.4));


            //var result = ListEmp.Where(Employe => Employe.Sal > 4000 && Employe.Sal < 6000).Select(Employe => Employe);

            //AffichageDonnees(result, "dd");
            //Console.WriteLine("---------------------------------------------------------------");

            //// var resultnom = ListEmp.OrderByDescending(Employe =>Employe.nom).ThenByDescending(Employe =>Employe.prenom).Select(Employe => Employe);

            //var resultnomTest = ListEmp.OrderBy(Employe => Employe.nom).ThenBy(Employe => Employe.prenom).Select(Employe => Employe);


            //AffichageDonnees(resultnomTest, "dd");

            //Console.WriteLine("-----------------------------------");
            //var resultnomDistinct = ListEmp.Select(Employe => Employe.prenom).Distinct();

            //AffichageDonnees(resultnomDistinct, "ff");

            //Console.WriteLine("----------------------------------------------");
            //var resultnomDistinctLambada = ListEmp.Select(Employe => (new { Employe.nom, Employe.prenom }));

            ////ou  Ca 

            //var listNomPrenomAnonyme = from p in ListEmp select new {p.nom,p.prenom };

            //AffichageDonnees(resultnomDistinctLambada, "ff");




            List<Paye> listPaye = new List<Paye>();
            listPaye.Add(new Paye("London", "UK",35000));
            listPaye.Add(new Paye("Paris", "France", 25000));
            listPaye.Add(new Paye("Lagos", "Nigeria", 45000));
            listPaye.Add(new Paye("Rome", "Italie", 15000));
            listPaye.Add(new Paye("New York", "USA", 125000));
            listPaye.Add(new Paye("London", "UK", 35000));
            listPaye.Add(new Paye("London", "UK", 35000));
            listPaye.Add(new Paye("London", "UK", 35000));
            listPaye.Add(new Paye("London", "UK", 35000));





        }
        //static void AffichageDonnees(IEnumerable<int> resultat, string texte)
        //{

        //    foreach (int f in resultat)
        //    {

        //        Console.WriteLine(f.ToString());


        //  }







        static void AffichageDonnees<T>(IEnumerable<T> resultat, string texte) {


            foreach (T t in resultat) {


                Console.WriteLine(t.ToString());


            }

        }
    }
}
