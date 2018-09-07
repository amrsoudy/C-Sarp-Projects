using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinallAmrSeoudyEx3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Etudiant> listEtudiant = new List<Etudiant>();
            listEtudiant.Add(new Etudiant("Anb11","Alain flouflou",50));
            listEtudiant.Add(new Etudiant("Pai22", "Abdel flouclair", 75));
            listEtudiant.Add(new Etudiant("ctl75", "Annie clair clair", 85));
            listEtudiant.Add(new Etudiant("Bv78", "albert brutus", 77));
            listEtudiant.Add(new Etudiant("Abl97", "Mina Jolie", 80));
            listEtudiant.Add(new Etudiant("Frc125", "toto Fourchette", 95));

            //ajouter dans noteEnter50Et77 tous les information demander  par methode extansible lambda
            var noteEnter50Et77 = listEtudiant.Where(Etudiant => Etudiant.note_finale >= 50 && Etudiant.note_finale <= 77).Select(Etudiant => Etudiant);

            // autre  version 
                //from item in listEtudiant
                //                  where (item.note_finale > 50 && item.note_finale < 77)
                //                  select item;



            Console.WriteLine("Question 1 ");
            Console.WriteLine("----------------");

            Afficher(noteEnter50Et77);
            Console.WriteLine("-----------------------------------------------------------------------------");


            var ListCodeNomAll = listEtudiant.Select(Etudiant => (new { Etudiant.code, Etudiant.nom }));


            Console.WriteLine("Question 2 ");
            Console.WriteLine("----------------");

            AfficherAll(ListCodeNomAll);



        }

        private static void AfficherAll<T>(IEnumerable<T> listCodeNomAll)
        {
            foreach (T i in listCodeNomAll)
            {

                Console.WriteLine(i);



            }
        }

        private static void Afficher(IEnumerable<Etudiant> noteEnter50Et77)
        {
            foreach (var i in noteEnter50Et77) {

                Console.WriteLine(i);
             


            }


           

        }

       
        }
    }

