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

namespace RevexamenFinalAdoDeconacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iT_CLIENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iT_CLIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amrDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'amrDBDataSet.IT_CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.iT_CLIENTTableAdapter.Fill(this.amrDBDataSet.IT_CLIENT);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                this.iT_CLIENTBindingSource.EndEdit();
                this.iT_CLIENTTableAdapter.Fill(this.amrDBDataSet.IT_CLIENT);


                this.iT_CLIENTTableAdapter.Update(this.amrDBDataSet.IT_CLIENT);


                //    this.iT_CLIENTTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                //    this.iT_CLIENTTableAdapter.Fill(this.amrDBDataSet.IT_CLIENT);
                //    this.iT_CLIENTTableAdapter.Update(this.amrDBDataSet.IT_CLIENT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.iT_CLIENTBindingSource.RemoveCurrent();
            this.iT_CLIENTTableAdapter.Update(this.amrDBDataSet.IT_CLIENT);


            foreach (Control c in panel1.Controls)
            {

                
                //if (c is TextBox)
                //{

                //    c.Text = "";
                //}
                //if (c is ComboBox)
                //{

                //    c.TabIndex = 0;

                //}



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                this.iT_CLIENTTableAdapter.SearchName(this.amrDBDataSet.IT_CLIENT, textBox6.Text);
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }



        

        }



        private void searchNameToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nameToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void insertToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.iT_CLIENTTableAdapter.insert(this.amrDBDataSet.IT_CLIENT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void iT_CLIENTDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
