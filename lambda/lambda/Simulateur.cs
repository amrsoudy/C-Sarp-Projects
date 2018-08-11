using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
    
{
    


    public partial class Simulateur : Form
    {
        publisher pub;
        int valeur;
        private static Simulateur simulateur;

        public string textObs1 {
            get { return this.outbut1.Text; }
            set { this.outbut1.Text = value; }

        }

        public string textObs2 { get => this.outbut2.Text; set => this.outbut2.Text = value; }


        public Simulateur()
        {
            InitializeComponent();
            attacherListner();
        }
        public static Simulateur GetInstance() {

            if (simulateur == null)
            {

                simulateur = new Simulateur();
                return simulateur;

            }
            else {

                return simulateur;
            }
        }

        private void attacherListner()
        {

            pub = new publisher();
            observer1 obs1 = new observer1();
            Observer2 obs2 = new Observer2();
            Observer3 obs3 = new Observer3();
            pub.valeurTempChanger += new Event.publisher.Mondelegate(obs1.EcrireSurEcran);
            pub.valeurTempChanger += new Event.publisher.Mondelegate(obs2.EcrireSurEcran);
            pub.valeurTempChanger += new Event.publisher.Mondelegate(obs3.EcrireSurjauge); 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pub.notifer(++valeur);
        }
    }
}
