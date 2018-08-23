using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXRevIntra_IMG
{
    public partial class Form1 : Form
    {
        private static Form1 form1;

        Publisher pub;

        public static Form1 getInstance()
        {

            if (form1 == null)
            {

                form1 = new Form1();
                return form1;

            }
            else
            {

                return form1;

            }


        }

        public Form1()
        {
            InitializeComponent();
            attacherLesObserveur();
        }



        internal void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        internal void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAllTextBoxes();
        }

        private void clearAllTextBoxes()
        {
            foreach (Control c in panel1.Controls)
            {

                if (c is TextBox)
                {
                    c.Text = "";

                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                }



            }
            foreach (Control c in panel2.Controls)
            {

                if (c is TextBox)
                {
                    MessageBox.Show(c.ToString());
                    c.Text = "";


                }



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            String text = textBox.Text;
            //[A-Za-z]
            if (!Regex.IsMatch(text, @"^[a-zA-Z ]+$"))
            {

                textBox.ForeColor = Color.Red;

            }
            else
            {

                textBox.ForeColor = Color.Black;

            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            TextBox textbox = (TextBox)sender;

            if (!Regex.IsMatch(textbox.Text, @"^[0-9.,]+$"))
            {


                textbox.ForeColor = Color.Red;


            }
            else
            {

                textbox.ForeColor = Color.Black;


            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            TextBox textbox = (TextBox)sender;

            if (!Regex.IsMatch(textbox.Text, @"^[0-9]+$"))
            {


                textbox.ForeColor = Color.Red;


            }
            else
            {

                textbox.ForeColor = Color.Black;


            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            TextBox textbox = (TextBox)sender;

            if (!Regex.IsMatch(textbox.Text, @"^[0-9]+$"))
            {


                textbox.ForeColor = Color.Red;


            }
            else
            {

                textbox.ForeColor = Color.Black;


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Utils.getInstance().calculer();


        }

        private void attacherLesObserveur()
        {
            pub = Publisher.getInstance();

            Observer obs1 = new Observer();
            Observeur2 obs2 = new Observeur2();

            

            pub.maValeurChanger += new EXRevIntra_IMG.Publisher.MonDelagate(obs1.ecrirejuage);
            pub.maValeurChanger += new EXRevIntra_IMG.Publisher.MonDelagate(obs2.ecrireTextBox);
         
        }
    }
}
