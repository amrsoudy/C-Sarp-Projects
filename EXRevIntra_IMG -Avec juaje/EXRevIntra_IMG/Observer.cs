using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXRevIntra_IMG
{
    class Observer
    {
        public  void ecrirejuage(object publisher, InfoEventArgs timeInfo)
        {

           


           Form1.getInstance().textBox6.Text = (timeInfo.val).ToString();
        }
    }
}
