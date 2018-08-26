using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSupDelegate
{
    class Publisher
    {
        public  delegate void MonDel(Object publisher,InfoEventArgs timeinfo);
        public event MonDel objDel;


        public void notify(double index) {

            InfoEventArgs timeValeur = new InfoEventArgs(index);

            onValChanget(this, timeValeur);

        }

        private void onValChanget(Publisher publisher, InfoEventArgs timeValeur)
        {
            if (objDel != null) {

                objDel(publisher, timeValeur);

            }
        }
    }
}
