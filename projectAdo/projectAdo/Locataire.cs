using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAdo
{
    public partial class Locataire : Form
    {
        MainForm form;
        public Locataire(MainForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void Locataire_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'amrDBDataSet.Locataires'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.locatairesTableAdapter.Fill(this.amrDBDataSet.Locataires);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel1.Controls) {

                if (c is TextBox) {
                    c.Text = "";
                }

                if (c is ComboBox) {

                    c.TabIndex = 0;

                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {

                MessageBox.Show("saisir locataire svp ","Gestion de locataire ",MessageBoxButtons.OK,MessageBoxIcon.Information);

                return;
            }
            if (textBox3.Text == "") {

                MessageBox.Show("saiasier nom et prenom SVP ", "Gestion de Locataire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            //insert  
            using (SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\1795162\\Documents\\AmrDB.mdf; Integrated Security = True; Connect Timeout = 30")) {


                SqlCommand commande = new SqlCommand("insert into Locataires(locataireCode,Nomprenom,Statutmariage,numerocontact) values('" + textBox1.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "');", connection);
                connection.Open();
                commande.ExecuteNonQuery();
                MessageBox.Show("un nouveau Locataire a été ajouter ", "Gestion de Locataire ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button2_Click(sender ,e);
                Locataire_Load(sender,e);



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Locataire_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            this.Visible = false;
            form.Visible = true;
        }
    }
}
