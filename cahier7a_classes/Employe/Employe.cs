using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Employe
    {
        public String code;
        public String nom;
        public String prenom;
        public String address;
        private String company;



        public String Company
        {

            get { return company; }
            set { company = "MomoStar"; }

        }



        public Employe(String code,String nom, String prenom, String address)
        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
            this.address = address;
            this.company = "MomoStar ";

        }


    }
}
