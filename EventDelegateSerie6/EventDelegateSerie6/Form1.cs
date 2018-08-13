using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDelegateSerie6
{
    public partial class Form1 : Form
    {

        Boolean modeEcoute = false; 
        public Form1()
        {
            InitializeComponent();
       
        }

        private void DemarreEcouter() {

            FileSystemWatcher watcher = new FileSystemWatcher(@"c:\Temp", "*.*");
            Microsoft.Win32.SystemEvents.DisplaySettingsChanged += new EventHandler(GereEcouteEcran);
            Microsoft.Win32.SystemEvents.TimeChanged += new EventHandler(GereEcouteHorloge);
         
            watcher.EnableRaisingEvents = true;
            watcher.Created += new FileSystemEventHandler(GereVerifiFolder);

            this.modeEcoute = true;
            
           

        }

        private void GereVerifiFolder(object sender, FileSystemEventArgs e)
        {
            this.richTextBox1.Invoke(new Action(()=> richTextBox1.Text = String.Format("Dossier cree. {0}{1}",e.FullPath, Environment.NewLine)));

        }

        private void ArreteEcoute() {


            Microsoft.Win32.SystemEvents.DisplaySettingsChanged -= new EventHandler(GereEcouteEcran);
            Microsoft.Win32.SystemEvents.TimeChanged -= new EventHandler(GereEcouteHorloge);
            this.modeEcoute = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DemarreEcouter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ArreteEcoute();
        }

        private void GereEcouteEcran(object sender, EventArgs e) {

            this.richTextBox1.Text += String.Format("changement de la resolution de ecran. {0}",Environment.NewLine);

        }
        private void GereEcouteHorloge(object sender, EventArgs e) {

            this.richTextBox1.Text += String.Format("Horloge a changer . {0}", Environment.NewLine);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.modeEcoute) {

                this.modeEcoute = false;
            }
        }
    }
}
