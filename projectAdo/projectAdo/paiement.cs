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
    public partial class paiement : Form
    {
        MainForm form;
        public paiement(MainForm form)
        {
            this.form = form;

            InitializeComponent();
        }

        private void paiementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paiementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amrDBDataSet1);

        }

        private void paiement_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'amrDBDataSet.bail'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bailTableAdapter.Fill(this.amrDBDataSet.bail);
            // TODO: cette ligne de code charge les données dans la table 'amrDBDataSet1.paiement'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.paiementTableAdapter.Fill(this.amrDBDataSet1.paiement);

        }

        private void paiement_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Visible = false;
            mainform.Visible = true;
        }
    }
}
