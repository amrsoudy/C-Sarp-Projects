using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    partial class personne1
    {

        public static void Main()
        {

            personne1 objPersonne = new personne1();
            objPersonne.nom = "Seoudy";
            objPersonne.prenom = "Amr";
            objPersonne.code = "A16";

            objPersonne.AfficheDetailsPersonne(objPersonne);



        }
    }
}
