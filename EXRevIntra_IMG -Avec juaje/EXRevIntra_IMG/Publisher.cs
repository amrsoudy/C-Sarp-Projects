using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRevIntra_IMG
{
    class Publisher
    {
        public delegate void MonDelagate(Object publisher, InfoEventArgs timeInfo);

        public event MonDelagate maValeurChanger;

        private static Publisher publisher;

     
        public static Publisher getInstance()
        {

            if (publisher != null)
            {

                return publisher;

            }
            else { }

            publisher = new Publisher();
            return publisher;

        }






        public void notify(double n)
        {
           
            InfoEventArgs infoTime = new InfoEventArgs(n);
            onvaleurChanger(this, infoTime);



        }

        private void onvaleurChanger(Publisher publisher, InfoEventArgs infoTime)
        {
            if (maValeurChanger != null)
            {
                
                maValeurChanger(publisher, infoTime);
                

            }

        }
    }
}
