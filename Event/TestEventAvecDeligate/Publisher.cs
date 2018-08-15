using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Publisher
<<<<<<< HEAD
    {
=======
    {// Objectp
>>>>>>> 5c106df91ef229bdd4f6ccf2b253c076826ff8f1
       public delegate void MonDelegate(InfoEventArgs timeInformation);

        public event MonDelegate maValeurTempChanger;
        public int temp { get; set; }

        public void notifer(int val) {

            temp = val;
            InfoEventArgs info = new InfoEventArgs(temp);
<<<<<<< HEAD
            onvalueChanger( info);

        }

        private void onvalueChanger(InfoEventArgs timeInformation)
=======
            onvalueChanger(info);

        }

        private void onvalueChanger( InfoEventArgs timeInformation)
>>>>>>> 5c106df91ef229bdd4f6ccf2b253c076826ff8f1
        {
            if (maValeurTempChanger != null) {
                maValeurTempChanger( timeInformation);

            }
        }
    }
}
