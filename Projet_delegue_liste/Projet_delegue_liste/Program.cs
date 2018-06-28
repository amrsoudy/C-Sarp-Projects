using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_delegue_liste
{
    //declarer delagte 
    delegate bool Observeur(int t);

    class Program
    {
        static void Main(string[] args)
        {
            //cree objet de delgate 
            Observeur m1 = new Ecuteur().EcouterMethode;
            Observeur m2 = new Printer().PrintMethode;

            //Collection de delduies 
            List<Observeur> register = new List<Observeur>();
            register.Add(m1);
            register.Add(m2);
            //demander aux observateur d faire le traville 

            foreach (Observeur tmp in register)
            {

               Console.WriteLine( tmp(100));

            }

            Console.ReadKey();

        }
        class Ecuteur
        {

            public bool EcouterMethode(int p)
            {

                Console.WriteLine("Ecoute: " + p*2);
                return true;

            }

        }
        class Printer
        {


            public bool PrintMethode(int q)
            {
                Console.WriteLine("Print: " + q*3);
                return false;


            }

        }

    }
}
