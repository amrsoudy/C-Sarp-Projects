using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace Gobal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CultureInfo ci = new CultureInfo("en-US");

            Assembly a = Assembly.Load("Gobal");
            ResourceManager rm = new ResourceManager("Gobal.Lang.LangRes", a);
            label1.Text = rm.GetString("fname", ci);
            label2.Text = rm.GetString("lname", ci);
            label3.Text = rm.GetString("age", ci);
            label4.Text = rm.GetString("persInf", ci);
            button1.Text = rm.GetString("reg", ci);
            pictureBox1.Image = (Image)rm.GetObject("flag", ci);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("fr-FR");

            Assembly a = Assembly.Load("Gobal");
            ResourceManager rm = new ResourceManager("Gobal.Lang.LangResFr", a);
            label1.Text = rm.GetString("fname", ci);
            label2.Text = rm.GetString("lname", ci);
            label3.Text = rm.GetString("age", ci);
            label4.Text = rm.GetString("persInf", ci);
            button1.Text = rm.GetString("reg", ci);
            pictureBox1.Image = (Image)rm.GetObject("flag", ci);
        }

       
    }
}
