using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observeur3
    {

<<<<<<< HEAD
        public void EcrireJauje(InfoEventArgs info) {
=======
        public void EcrireJauje( InfoEventArgs info) {
>>>>>>> 5c106df91ef229bdd4f6ccf2b253c076826ff8f1

            Simulateur.GetInstance().jauje.Value = info.valeur;
            Simulateur.GetInstance().jauje.DialText = info.valeur.ToString();



        }
    }
}
