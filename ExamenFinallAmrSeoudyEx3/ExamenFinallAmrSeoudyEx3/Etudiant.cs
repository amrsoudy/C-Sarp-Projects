using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinallAmrSeoudyEx3
{
    class Etudiant
    {

        public String code;
        public String nom;
        public  double note_finale;
      

        public Etudiant(string code, string nom, double note)
        {
            this.code = code;
            this.nom = nom;
            this.note_finale = note;
        }

        public override string ToString()
        {
            return "Code  :   " + code + " - nom  :    " + nom + "     note finale  : " + note_finale;
        }
    }
}
