using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observeur3
    {

        public void EcrireJauje( InfoEventArgs info) {

            Simulateur.GetInstance().jauje.Value = info.valeur;


        }
    }
}
