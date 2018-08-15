using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observer4
    {
<<<<<<< HEAD
        public void EcrireJuaje2(InfoEventArgs info) {
=======
        public void EcrireJuaje2( InfoEventArgs info) {
>>>>>>> 5c106df91ef229bdd4f6ccf2b253c076826ff8f1

            Simulateur.GetInstance().jauje2.Value = info.valeur2;
            Simulateur.GetInstance().jauje2.DialText = info.valeur2.ToString();



        }
    }
}
