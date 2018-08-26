using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSupDelegate
{
    class InfoEventArgs :EventArgs
    {
        public readonly double valeur;

        public InfoEventArgs(double res) {

            this.valeur = res;

        }
    }
}
