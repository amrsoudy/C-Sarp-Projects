using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Observeur1
    {
        public delegate void DeuxDelegate(InfoEventArgs timeInformation);
        public event DeuxDelegate deuxValeurTempChanger;
        int temp = 0;

        public void EcrireEcran(InfoEventArgs info)
        {


            Simulateur.GetInstance().Testobs1 = "observer  1 " + info.valeur;
            notifer(info.valeur);




    }
        public void notifer(int val)
        {

            temp = val;
            InfoEventArgs info = new InfoEventArgs(temp);
            onvalueChanger(info);

        }

        private void onvalueChanger(InfoEventArgs timeInformation)
        {
            if (deuxValeurTempChanger != null)
            {
                deuxValeurTempChanger(timeInformation);

            }
        }
    }
}
