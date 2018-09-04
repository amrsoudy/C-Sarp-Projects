using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectAdo
{
    public partial class Bail : Form
    {

        Form form;
        public Bail(MainForm  form )
        {
            this.form = form;
            InitializeComponent();
        }

        private void bailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amrDBDataSet1);
            MessageBox.Show("inserted", "Gestion de bail", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Bail_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'amrDBDataSet1.paiement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.paiementTableAdapter.Fill(this.amrDBDataSet1.paiement);
            // TODO: cette ligne de code charge les données dans la table 'amrDBDataSet1.bail'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bailTableAdapter.Fill(this.amrDBDataSet1.bail);

        }

        private void Bail_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            this.Visible = false;
            form.Visible = true;
        }
    }
}
