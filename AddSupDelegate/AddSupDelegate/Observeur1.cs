using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSupDelegate
{
    class Observeur1
    {

        public void ecrireDansRich(Object publisher, InfoEventArgs timeinfo) {


            Form1.getInstance().richTextBox1.AppendText((timeinfo.valeur).ToString());

        }
    }
}
