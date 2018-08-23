using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public delegate double Mondelagate(double A, double B);

    public partial class Form1 : Form
    {
        List<Mondelagate> ObjDelegate = new List<Mondelagate>();

        


        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("add");
            comboBox1.Items.Add("sub");

            ObjDelegate.Add(add);
            ObjDelegate.sub(add);




        }

        private double sub(double v1, double v2)
        {
            return v1 + v2;
        }

        private double add(double v1, double v2)
        {
            
        }
    }
}
