using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphiqueEventsAvecDelegation
{
    public partial class Simulateur : Form
    {
        Publisher pub;
        int valeur;
        private static Simulateur simulateur;
        private Simulateur()
        {
            InitializeComponent();
            attacherListeners();
        }

      

        public static Simulateur getInstance() {


            if (simulateur == null)
            {
                simulateur = new Simulateur();
                return simulateur;
            }
            else {
                return simulateur;
            }

        }
        private void attacherListeners()
        {
            pub = new Publisher();
            Observer1 obs1 = new Observer1();
            Observer2 obs2 = new Observer2();

        }

    }
}
