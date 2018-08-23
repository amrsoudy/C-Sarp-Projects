using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_bouton_2015
{
    public partial class Form1 : Form
    {
        Publicher pub = new Publicher();
        Observeur1 obs1 = new Observeur1(); 
       
        int valeur = 0 ;
        private static Form1 form1;

        public static Form1 getInstancie() {
            if (form1 == null)
            {

                form1 = new Form1();
                return form1;
            }
            else {
                return form1;
            }


        }
        public Form1()
        {
            InitializeComponent();
            attacher();


        }

        private void userBouton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton a été cliqué!");
        }

        private void Afficher_Click(object sender, EventArgs e)
        {
            //Bouton1.Mesure = Convert.ToInt16(TxtMesure.Text);
            pub.notify(Convert.ToInt16(TxtMesure.Text));

        }

        private void button1_Click(object sender, EventArgs e)
        {

            attacher();
           


        }

        private void button2_Click(object sender, EventArgs e)
        {

            dtacher();

        }

        public void attacher() {

            pub.maValeurChanger += new Publicher.MonDelgate(obs1.ecrireJuaje);
       

        }
        public void dtacher() {
            pub.maValeurChanger -= new Publicher.MonDelgate(obs1.ecrireJuaje);
        

        }
    }
}
