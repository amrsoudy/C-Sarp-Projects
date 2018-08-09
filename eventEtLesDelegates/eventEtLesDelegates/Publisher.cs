using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventEtLesDelegates
{
    public delegate void MonDelegue(String input);
    class Publisher
    {
       
       public int temp { get; set; }
        public event MonDelegue ValeurTemperatureChange;

        public void notifier( int val) {

            temp = val;
            onValeurTemperatureChanger("Demarrage" + temp);
    }

        private void onValeurTemperatureChanger(string message)
        {
            if (ValeurTemperatureChange != null) {

                ValeurTemperatureChange(message);
            }
        }
    }
}


