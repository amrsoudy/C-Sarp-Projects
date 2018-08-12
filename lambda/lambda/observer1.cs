using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class observer1
    {
        public  void EcrireSurEcran(Object publisher ,InfoEventArgs timeInformation) {

            Simulateur.GetInstance().textObs1 = "Observeur 1 : " + timeInformation.valeur;

        }
    }
}
