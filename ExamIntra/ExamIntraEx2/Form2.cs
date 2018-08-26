using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamIntraEx2
{
    
    public partial class Form2 : Form
    {
        Utils util = Utils.getInstance();


        private static Form2 form2;
        Form1 form1 = Form1.getInstance();
        public static Form2 getInstance() {

            if (form2 == null)
            {

                form2 = new Form2();
                return form2;

            }
            else
            {
                form2 = new Form2();

                return form2;

            }

        }
        //pour proteger la constructeur pour instancier un seul objet 
        private Form2()
        {
            InitializeComponent();
            Afficher();
        }

        private void Afficher()
        {
           
                label1.Text = "Mr " + Utils.getInstance().Nom+ " , " + util.Prenom;
                label2.Text = util.corrial.ToString();
                label3.Text = "Merci d'avoir rempli votre déclaration fiscale .";
                label4.Text = "Voici les mountants qui vous concernent .";
                label5.Text = "Mountant déclaré : " + util._mountant + " $";
                label6.Text = "Contisation déclarée : " + util._Costisation + " $";
                label7.Text = "Remboursement auquel vous avez droit : " + util.Remb + " $";
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            foreach (Control c in form1.panel1.Controls)
            {

                if (c is TextBox)
                {
                    c.Text = "";


                }
                form1.Show();
            }
        }
    }
}
