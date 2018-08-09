using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphiqueEventsAvecDelegation
{
    class Publisher
    {
        public delegate void MonDelegue(Object publisher, InfoEventArgs timeInformation);
           
        public int temp { get; set; }
        public event MonDelegue ValeurTemperatureChange;
        public void notifier(int val) {
            temp = val;
            InfoEventArgs infoEvent = new InfoEventArgs(temp);
            onValeurTemperatureChanger(this, infoEvent);

        }

        private void onValeurTemperatureChanger(Publisher publisher, InfoEventArgs timeInformation)
        {
            if (ValeurTemperatureChange != null) {

                ValeurTemperatureChange(publisher, timeInformation);
            }

        }
    }
}
