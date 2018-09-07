using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalleAmrSeoudy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'northwndDataSet.Customers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.customersTableAdapter.Fill(this.northwndDataSet.Customers);

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ici on chercher par Contact name Que commance avec K 
                this.customersTableAdapter.selectParContactK(this.northwndDataSet.Customers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //ici on chercher dans la dataset a le mot que il ecrire  avec  Like %+ textBox1.Text+%
                this.customersTableAdapter.chercherParContact(this.northwndDataSet.Customers, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
