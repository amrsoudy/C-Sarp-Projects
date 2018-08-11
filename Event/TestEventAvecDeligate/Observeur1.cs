using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observeur1
    {
        public void EcrireEcran(Object publisher, InfoEventArgs info) {


            Simulateur.GetInstance().Testobs1 = "observer  1 " +info.valeur;


        }
    }
}
