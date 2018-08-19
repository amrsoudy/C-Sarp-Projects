using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cah1_manip1
{
    public class Utilitaire
    {

        public bool statuts { get; set; }

        public double addition(double a, double b) {

            statuts = true;
            return a + b;

        }



    }
}
