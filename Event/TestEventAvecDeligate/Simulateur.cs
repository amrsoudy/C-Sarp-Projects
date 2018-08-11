using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEventAvecDeligate
{
    public  partial class Simulateur : Form
    {
        private static Simulateur simulateur;
        Publisher pub;
        int Valeur;
        Observeur3 obs3;
        Observeur2 obs2;
        Observeur1 obs1;
        Observer4 obs4;
         Observeur5 obs5;



        public String Testobs1 { get { return this.output1.Text; } set { this.output1.Text = value; } }

        public String Testobs2 { get { return this.output2.Text; } set { this.output2.Text = value; } }


        public Simulateur()
        {
            InitializeComponent();
            AttacherLesObservers();
        }

        

        public static  Simulateur GetInstance() {

            if (simulateur != null)
            {

                return simulateur;


            }
            else {

                simulateur = new Simulateur();
                return simulateur;

            }


        }

        private void AttacherLesObservers()
        {
             pub = new Publisher();
             obs1 = new Observeur1();
             obs2 = new Observeur2();
             obs3 = new Observeur3();
            obs4 = new Observer4();
            obs5 = new Observeur5();
            pub.maValeurTempChanger += new Publisher.MonDelegate(obs1.EcrireEcran);
            pub.maValeurTempChanger += new Publisher.MonDelegate(obs2.ecrireEcran);
            pub.maValeurTempChanger += new Publisher.MonDelegate(obs3.EcrireJauje);
            pub.maValeurTempChanger += new Publisher.MonDelegate(obs4.EcrireJuaje2);
            pub.maValeurTempChanger += new Publisher.MonDelegate(obs5.EcrireJuaje2);




        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            pub.notifer(++Valeur);
        }
        private void button2_Click(object sender, EventArgs e)
        {
         
            
                RemoveFromPub();
            

            
        }
        int x = 0;

        private void RemoveFromPub()
        {
            if (x == 0)
            {
                pub.maValeurTempChanger -= new Publisher.MonDelegate(obs5.EcrireJuaje2);

                x = 1;

            }
            else if (x == 1)
            {
                pub.maValeurTempChanger -= new Publisher.MonDelegate(obs4.EcrireJuaje2);


                x = 2;
            }
            else if (x == 2) {
                pub.maValeurTempChanger -= new Publisher.MonDelegate(obs3.EcrireJauje);

                x = 3;
                

            }
            else if (x == 3)
            {
                pub.maValeurTempChanger -= new Publisher.MonDelegate(obs2.ecrireEcran);

                x = 4;


            }

            else if (x == 4)
            {
                pub.maValeurTempChanger -= new Publisher.MonDelegate(obs1.EcrireEcran);

                x = 5;


            }
            else if(x == 5)
            {
                x = 0;

                AttacherLesObservers();


            }
        }
    }
}
