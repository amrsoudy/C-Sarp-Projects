using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_bouton_2015
{
    class Observeur1
    {
        public void ecrireJuaje(object publisher, InfoEventArgs timevalue)
        {
            Form1.getInstancie().userBoutonfirst.Mesure = timevalue.val;
        }
    }
}
