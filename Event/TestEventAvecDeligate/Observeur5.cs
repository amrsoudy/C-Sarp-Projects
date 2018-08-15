using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observeur5
    {
<<<<<<< HEAD
        public void EcrireJuaje2(InfoEventArgs info)
=======
        public void EcrireJuaje2( InfoEventArgs info)
>>>>>>> 5c106df91ef229bdd4f6ccf2b253c076826ff8f1
        {

           // Simulateur.GetInstance().jauje3.Value = info.valeur3;
           Simulateur.GetInstance().jauje3.DialText = info.valeur3.ToString();




        }
    }
}
