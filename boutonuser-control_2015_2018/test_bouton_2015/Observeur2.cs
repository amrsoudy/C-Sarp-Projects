using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_bouton_2015
{
    class Observeur2
    {
        internal void ecrireJuaje(object publisher, InfoEventArgs timevalue)
        {
            Form1.getInstancie().userBouton1.Mesure = timevalue.val+20;
        }
    }
}
