using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace PrintAndSaveFile
{
    
   
    public partial class Form1 : Form
    {
        PrintDocument pDoc = new PrintDocument();
        public Form1()
        {

            
            InitializeComponent();

            pDoc.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);


        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog op = openFile;

            if (op.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);

                this.Text = openFile.FileName;

            }


        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {


            SaveFileDialog sv = saveFile;
            sv.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);

                this.Text = sv.FileName;
            }



        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            richTextBox1.Clear();

        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void rétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            fd.Font = richTextBox1.SelectionFont;

            if (fd.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SelectionFont = fd.Font;

            }


        }

        private void backGroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.BackColor = cd.Color;

            }


        }

        private void aideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version de Amt Note Pad est v  1.0 ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
                PrintDialog pdo = new PrintDialog();

            pdo.Document = pDoc;
            if (pdo.ShowDialog() == DialogResult.OK) {


                pDoc.Print();

            } 

        }
    }
}
