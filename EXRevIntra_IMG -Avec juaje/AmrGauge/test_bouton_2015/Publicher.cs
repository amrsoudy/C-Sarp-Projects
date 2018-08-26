using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_bouton_2015
{
    class Publicher
    {
        public delegate void MonDelgate(Object publisher, InfoEventArgs timevalue);
        public event MonDelgate maValeurChanger;
        int temp;
        public void notify(int val) {

            temp = val;
            InfoEventArgs timeval = new InfoEventArgs(temp);
            onvalueChanger(this,timeval);


        }

        private void onvalueChanger(Publicher publicher, InfoEventArgs timeval)
        {
            if (maValeurChanger != null) {


                maValeurChanger(publicher, timeval);

            }
        }
    }
    }
