using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFClient.ServiceReference1;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        Service1Client client = new Service1Client("BasicHttpBinding_IService1");
        
        public Form1()
        {
            InitializeComponent();
            monthCalendar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            String MachineName = System.Environment.MachineName;
            String MachineUserName = System.Environment.UserName;
            String MachineIp =  Dns.GetHostAddresses(MachineName)[0].ToString();

            DateTime date = DateTime.Now;

            //   DateTime DateComplete = monthCalendar1.SelectionRange.Start;
            DateTime DateComplete = DateTime.Parse(textBox1.Text);


           // String[] split = textBox1.Text.Split('-');



            // int.TryParse(textBox1.Text, out year);

            //   label2.Text = MachineName +"--- "+ MachineUserName + "--- " + MachineIp;

            String s = client.Verifier(DateComplete, MachineName, MachineIp, MachineUserName, date);

            MessageBox.Show((" Notre Conseil est :  " + s),"LE RESULTE ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();

            monthCalendar1.Visible = false;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }
    }
}
