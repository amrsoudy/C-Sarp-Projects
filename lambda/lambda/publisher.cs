using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class publisher
    {
        public delegate void Mondelegate(Object publisher, InfoEventArgs timeInformation);

        public int temp  { get; set; }

        public event Mondelegate valeurTempChanger;

        public void notifer(int val) {

            temp = val;
            InfoEventArgs infoEvent = new InfoEventArgs(temp);

            onValuerTempChanger(this, infoEvent);

        }

        private void onValuerTempChanger(publisher publisher, InfoEventArgs timeInformation)
        {
            if (valeurTempChanger != null) {
                valeurTempChanger(publisher, timeInformation);
            }
        }
    }


    }
    

