using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revExamenFinalPratique
{
    class Produit
    {

        public string code;
        public string descraption;
       public  double prix;
       

        public Produit(string v1, string v2, double v3)
        {
            this.code = v1;
            this.descraption = v2;
            this.prix = v3;
        }

        public override string ToString()
        {
            return "code est  : " + code + "  " + "desc" + descraption + " prix " + prix;
        }


    }
}
