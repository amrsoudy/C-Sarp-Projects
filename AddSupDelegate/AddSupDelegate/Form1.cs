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
        public Form1()
        {
            InitializeComponent();
            RempCompoBox();
        }

        private void RempCompoBox()
        {

            comboBox1.Items.Add("add");
            comboBox1.Items.Add("sup");


        }
    }
}
