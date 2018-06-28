using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShopDelegate
{
    delegate void MonDelegueRecherche();

    public partial class Form1 : Form
    {
        List<MonDelegueRecherche> listDelegues;
        public Form1()
        {
            InitializeComponent();
            listDelegues = new List<MonDelegueRecherche>();
            ajouterDelegues();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rechercheParNom()
        {

            tb_resultat.AppendText("recherche par nom est lancéé");

        }
        private void rechercheParPrenom()
        {

            tb_resultat.AppendText("recherche par prenom est lancéé");

        }
        private void rechercheParNomPrenom()
        {

            tb_resultat.AppendText("recherche par Nom et prenom est lancéé");

        }

        private void ajouterDelegues()
        {

            cb_recherche.Items.Add("Rechercher par Nom");
            cb_recherche.Items.Add("Rechercher par préNom");
            cb_recherche.Items.Add("Rechercher par Nom et prenom");

            listDelegues.Add(rechercheParNom);
            listDelegues.Add(rechercheParPrenom);
            listDelegues.Add(rechercheParNomPrenom);

        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            if (cb_recherche.SelectedIndex != -1) {
                tb_resultat.Clear();
                listDelegues[cb_recherche.SelectedIndex]();


           }
        }
    }
}
