using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Observer3
    {

        public void EcrireSurjauge(Object publisher, InfoEventArgs timeInformation)
        {

            Simulateur.GetInstance().jauge.Value = timeInformation.valeur;

        }
    }
}
