using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqSerie9toObject
{
    class Employe
    {
        public String nom;
        public String prenom;
        private  double salaire;


        public  double Sal {

            get {return salaire; }
            set{ salaire = value; }


        }




        public Employe(String nom , string prenom,double salaire) {

            this.nom = nom;
            this.prenom = prenom;
            this.salaire = salaire;

        }

        public override string ToString()
        {
            return "Employee    " + nom + " prenom       " + prenom + "Avec salaire            " + Sal;
        }
    }
}
