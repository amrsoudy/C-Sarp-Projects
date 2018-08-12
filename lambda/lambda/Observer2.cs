using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Observer2
    {
        public void EcrireSurEcran(Object publisher, InfoEventArgs timeInformation)
        {
            Simulateur.GetInstance().textObs2 = "Observeur 2 : " +( timeInformation.valeur + 23);


        }
    }
}
