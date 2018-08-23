using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_bouton_2015
{
    class InfoEventArgs :EventArgs
    {
       public  int val;

        public InfoEventArgs(int val) {
            this.val = val;

        }
    }
}
