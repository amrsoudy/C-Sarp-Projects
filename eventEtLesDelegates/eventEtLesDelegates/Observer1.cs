using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventEtLesDelegates
{
    class Observer1
    {
        public void EcrireEcran(String mess) {


            Console.WriteLine("Observateur 1 : " + mess);
        }
    }
}
