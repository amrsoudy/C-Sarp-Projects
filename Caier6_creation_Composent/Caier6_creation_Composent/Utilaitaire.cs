using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cah1_mainp1
{
    public class Utilaitaires

    {
        public bool statut { get; set; }

        public double addition(double val1, double val2) {


            statut = true;
            return val1 + val2;
        }
    }
}
