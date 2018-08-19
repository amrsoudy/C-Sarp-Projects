using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_bouton_2015
{
    class Observeur3
    {
        internal void ecrireJuaje(object publisher, InfoEventArgs timevalue)
        {
            Form1.getInstancie().userBouton2.Mesure = timevalue.val+50;
        }
    }
}
