using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observeur2
    {
        public void ecrireEcran(Object publisher, InfoEventArgs info) {

            Simulateur.GetInstance().Testobs2 = "Observer 2 " + (info.valeur + 23);

        }
    }
}
