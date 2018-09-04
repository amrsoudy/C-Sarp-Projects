using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clientTemprateur.ServiceReference1;

namespace clientTemprateur
{
    public partial class Form1 : Form
    {
        WebService1SoapClient proxy;


        public Form1(WebService1SoapClient proxy)
        {

            this.proxy = proxy;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = "";

            double a;
            if (Double.TryParse(textBox1.Text, out a))
            {

                double res = proxy.Calcultemp(a, "c", out msg);

                textBox3.Text = res.ToString();
                textBox2.Text = msg;

            }
            else
            {

                textBox2.Text = "SVP ecrire number ";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String msg = "";

            double a;
            if (Double.TryParse(textBox1.Text, out a))
            {

                double res = proxy.Calcultemp(a, "c", out msg);

                textBox3.Text = res.ToString();
                textBox2.Text = msg;

            }
            else
            {

                textBox2.Text = "SVP ecrire number ";
            }
        }


    }
}
