using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        enum color {Red,Blue,Green};

        struct Point {
            


        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utils.convertfrom1to2(textBox1, textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utils.convertfrom2to1(textBox1, textBox2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
