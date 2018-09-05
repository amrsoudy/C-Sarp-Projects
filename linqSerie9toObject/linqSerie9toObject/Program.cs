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
            //join jointeur 


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
            listPaye.Add(new Paye("London", "UK", 35000));
            listPaye.Add(new Paye("Paris", "France", 25000));
            listPaye.Add(new Paye("Lagos", "Nigeria", 45000));
            listPaye.Add(new Paye("Rome", "Italie", 15000));
            listPaye.Add(new Paye("New York", "USA", 125000));
            listPaye.Add(new Paye("Chicago", "USA", 105000));
            listPaye.Add(new Paye("Boston", "USA", 45000));
            listPaye.Add(new Paye("Oslo", "Norvege", 5000));
            listPaye.Add(new Paye("Baltimore", "USA", 65000));
            listPaye.Add(new Paye("Accra", "Ghana", 25000));
            listPaye.Add(new Paye("Milan", "Italie", 15000));


            List<Persone> listPerson = new List<Persone> {

                new Persone{ name = "Bill",prenom = "Tages",city = "New York"},
                new Persone{ name = "Olanjo",prenom = "Bobard",city = "Lagos"},
new Persone{ name = "Alain",prenom = "FlouFlou",city = "Boston"},
new Persone{ name = "Wate",prenom = "Kinslet",city = "Paris"},
new Persone{ name = "Loria",prenom = "Soren",city = "Rome"},
new Persone{ name = "Tamar",prenom = "Kuhl",city = "Chicago"},
new Persone{ name = "Romeo",prenom = "Unede",city = "Accra"},
new Persone{ name = "Simur",prenom = "Tarsen",city = "Oslo"},
new Persone{ name = "Rudici",prenom = "Miluci",city = "Milan"},
new Persone{ name = "Bill",prenom = "Thorsen",city = "New York"},
new Persone{ name = "Avanti",prenom = "Sage",city = "Rome"},
new Persone{ name = "Billio",prenom = "Mustardi",city = "Rome"},
new Persone{ name = "Cameo",prenom = "Donadi",city = "Rome"},    };


            Console.WriteLine("11111111111111111111111111111111111111111111111111111111111");

            innerJoienMethode(listPaye, listPerson);
            Console.WriteLine("222222222222222222222222222222222222222222222222222222222222");

            listNomPersonViv(listPaye, listPerson);
            Console.WriteLine("3333333333333333333333333333333333333333333333333333333333333");

            personeViveARome(listPaye, listPerson);
            Console.WriteLine("44444444444444444444444444444444444444444444444444444444444444");

            payesAPlusDe2Personne(listPaye, listPerson);
            Console.WriteLine("5555555555555555555555555555555555555555555555555555555555555");

            villeWithAllPersones(listPaye, listPerson);




        }


        private static void innerJoienMethode(List<Paye> listPaye, List<Persone> listPerson)
        {

            var innerJoin = from p in listPaye
                            join per in listPerson
         on p.city equals per.city
                            select new { cityName = p.city , name = per.name};



            //  var listville = listPerson.Select(Persone => Persone.city).Distinct();




            //AffichageDonnees(listville, "ggg");
            Console.WriteLine();



            AffichageDonnees(innerJoin, "fff");
            Console.WriteLine();
        }

        public static void listNomPersonViv(List<Paye> listPaye, List<Persone> listPerson)
        {


            var perPaye = from p in listPaye join per in listPerson on p.city equals per.city select new { name = per.name, Paye = p.Ville };

            AffichageDonnees(perPaye, "fff");
            Console.WriteLine();


        }

        public static void personeViveARome(List<Paye> listPaye, List<Persone> listPerson)
        {



            // var perDansRome = from p in listPaye join per in listPerson on p.city equals per.city select new { name = per.name ,per.prenom };


            var perDansRome = listPerson.Where(Persone => Persone.city == "Rome").Select(Persone => new { Persone.name, Persone.prenom });
            AffichageDonnees(perDansRome, " persone vivre dans Rome ");


        }

        public static void payesAPlusDe2Personne(List<Paye> listPaye, List<Persone> listPerson)
        {

            Console.WriteLine();
            Console.WriteLine();
            var payesAPlusDe2Pers = from p in listPaye
                                    join per in listPerson on
                                     p.city equals per.city
                                     //group in chaque ville the persones 
                                     group per.name by p.city
                                     //on cree ici la View comme view de DB
                                     into groups
                                     //ici on a fait filter dans la view 
                                     //if the continue de eash group plus que 2
                                     where(groups.ToList().Count() >= 2)
                                    //afficher les payes avec le number de personne que vivre dans 
                                    select new { ville = groups.Key, personecount = groups.ToList().Count() };
                                   // select new { ville = groups.Key, personenames = groups.ToList() };

     



            AffichageDonnees(payesAPlusDe2Pers, "jjjj");
            Console.WriteLine();



        }

        public static void villeWithAllPersones(List<Paye> listPaye, List<Persone> listPerson)
        {

            var groupVilleEtToutLesPersonne = from p in listPaye
                                              join per in listPerson on p.city equals per.city
                                              group per.name by p.city
                                              into groups
                                              select new
                                              {
                                                  villeName = groups.Key,
                                                  personesNames = groups.ToList()

                                              };

            foreach (var g in groupVilleEtToutLesPersonne) {

                Console.WriteLine(g.villeName);
                foreach (var h in g.personesNames) {


                    Console.WriteLine("    -"+h);


                }

            }



        }

        //static void AffichageDonnees(IEnumerable<int> resultat, string texte)
        //{

        //    foreach (int f in resultat)
        //    {

        //        Console.WriteLine(f.ToString());


        //  }







        static void AffichageDonnees<T>(IEnumerable<T> resultat, string texte)
        {


            foreach (T t in resultat)
            {


                Console.WriteLine(texte + "   ----    " + t.ToString());


            }

        }
    }
}
