using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSupDelegate
{

    public partial class Form1 : Form
    {
        Publisher pub = new Publisher();
        private static Form1 form1;
        Observeur1 obs1 = new Observeur1();

        public static Form1 getInstance() {

            if (form1 == null)
            {

                form1 = new Form1();
                return form1;
            }
            else {

                return form1;
            }

        }



        private Form1()
        {
            InitializeComponent();
            RempCompoBox();
            attacher();
    }

        private void attacher()
        {

            pub.objDel += new Publisher.MonDel(obs1.ecrireDansRich);

        }

        private void RempCompoBox()
        {

        comboBox1.Items.Add("add");
            comboBox1.Items.Add("sup");
            
         



        }


        public double add(double a, double b) {


            return a + b;

        }
        public double sup(double a, double b)
        {


            return a - b;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (!(comboBox1.SelectedIndex == -1))
            {
                richTextBox1.Clear();
                int index = comboBox1.SelectedIndex;

               pub.notify(Utils.getInstance().calcul(index));


            }
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
          
        }
    }
}
