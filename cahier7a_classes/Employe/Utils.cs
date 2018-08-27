using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Utils
    {
        public static String ConcatenationNomPrenom(String nom, String prenom) {

            String nom1 = nom.ToUpper();
            String prenom1 = prenom.ToUpper();


            return nom1 + "  " + prenom1;


        }
        public static String ModifierCode(String code){

            if (code.ToUpper().StartsWith("A") || code.ToUpper().StartsWith("B")|| code.ToUpper().StartsWith("F")|| code.ToUpper().StartsWith("M")) {
                code = "AXD" + code;
               

            }

            return code;

}


    }
}
