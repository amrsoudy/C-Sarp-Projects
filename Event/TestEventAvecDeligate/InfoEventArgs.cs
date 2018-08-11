using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class InfoEventArgs :EventArgs
    {
       public readonly int valeur;
        public readonly int valeur2;
        public readonly int valeur3;



        public InfoEventArgs(int x) {


            this.valeur = x;
            this.valeur2 = x + 10;
            this.valeur3 = x + 50;
        }
    }
}
