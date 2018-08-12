using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventAvecDeligate
{
    class Publisher
    {
       public delegate void MonDelegate(Object Publisher ,InfoEventArgs timeInformation);

        public event MonDelegate maValeurTempChanger;
        public int temp { get; set; }

        public void notifer(int val) {

            temp = val;
            InfoEventArgs info = new InfoEventArgs(temp);
            onvalueChanger(this, info);

        }

        private void onvalueChanger(Publisher publisher, InfoEventArgs timeInformation)
        {
            if (maValeurTempChanger != null) {
                maValeurTempChanger(publisher, timeInformation);

            }
        }
    }
}
