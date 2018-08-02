using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using publiothequeDeAnneDesGens;
namespace NotationComposontSerie2Anne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            int currentyear = DateTime.Now.Year;

            for (int i = 1950; i <= currentyear-8; i++)
            {

                comboBox1.Items.Add(i);
                int index  =comboBox1.SelectedIndex;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Amr_Verification amr_verfication = new Amr_Verification();

            String s = amr_verfication.verifier(int.Parse(comboBox1.SelectedItem.ToString()));
            richTextBox1.Text = s;

        }
    }
}
