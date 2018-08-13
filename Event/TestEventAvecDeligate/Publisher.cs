using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Publisher
    {// Objectp
       public delegate void MonDelegate(InfoEventArgs timeInformation);

        public event MonDelegate maValeurTempChanger;
        public int temp { get; set; }

        public void notifer(int val) {

            temp = val;
            InfoEventArgs info = new InfoEventArgs(temp);
            onvalueChanger(info);

        }

        private void onvalueChanger( InfoEventArgs timeInformation)
        {
            if (maValeurTempChanger != null) {
                maValeurTempChanger( timeInformation);

            }
        }
    }
}
