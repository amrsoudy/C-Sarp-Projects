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

namespace ExamIntraEx2
{
    public partial class Form1 : Form
    {

        private static Form1 form1;
        //Singleton methode pour cree un seul objet de Form1
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
        private Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.getInstance().calculer();
            
            
           
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
            TextBox textBox = (TextBox)sender;

            String text = textBox.Text;

            if (!Regex.IsMatch(text, @"^[a-zA-Z ]+$"))
            {

                textBox.ForeColor = Color.Red;

            }
            else
            {

                textBox.ForeColor = Color.Black;

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
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

            if (!Regex.IsMatch(textbox.Text, @"^[a-zA-Z0-9.@-_]+$"))
            {


                textbox.ForeColor = Color.Red;


            }
            else
            {

                textbox.ForeColor = Color.Black;


            }

        }
    }
}
