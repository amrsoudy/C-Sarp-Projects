using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n8
{


      class Program
    {
        public struct date
        {
            public   int annee;
            public int mois;
            public int jour;



        }
        static void Main(string[] args)
        {
            Utils.demande();
            Utils.AfficherLaDate();
            Utils.afficheNextJour();
            

        }
    }
}
