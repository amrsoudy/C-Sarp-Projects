using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observer4
    {
        public void EcrireJuaje2(InfoEventArgs info) {

            Simulateur.GetInstance().jauje2.Value = info.valeur2;


        }
    }
}
