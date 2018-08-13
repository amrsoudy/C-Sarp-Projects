using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observeur5
    {
        public void EcrireJuaje2( InfoEventArgs info)
        {

            Simulateur.GetInstance().jauje3.Value = info.valeur3;


        }
    }
}
