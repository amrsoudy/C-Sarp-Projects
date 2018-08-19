using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManipulation
{
    public partial class Form1 : Form
    {
        private List<String> _list = new List<string>();


                public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            _list.Add(textBox1.Text);
            listBox1.Items.Add(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String selecteditemTex = listBox1.SelectedItem.ToString();
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox2.Items.Add(selecteditemTex);
            _list.RemoveAt(index);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String selecteditemTex = listBox2.SelectedItem.ToString();
            int index = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(index);
            listBox1.Items.Add(selecteditemTex);

        }
    }
    }

