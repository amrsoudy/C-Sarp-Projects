using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRevIntra_IMG
{
    class Observeur2
    {
        public  void ecrireTextBox(object publisher, InfoEventArgs timeInfo)


        {

            Form1.getInstance().userBouton1.Mesure = int.Parse(timeInfo.val.ToString());
            
        }
    }
}
