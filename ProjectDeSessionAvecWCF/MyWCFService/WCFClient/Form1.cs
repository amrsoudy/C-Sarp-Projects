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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String MachineName = System.Environment.MachineName;
            String MachineUserName = System.Environment.UserName;
            String MachineIp =  Dns.GetHostAddresses(Environment.MachineName)[0].ToString();

            DateTime date = DateTime.Now;
          
            int year;


            String[] split = textBox1.Text.Split('-');
            int.TryParse(textBox1.Text, out year);

         //   label2.Text = MachineName +"--- "+ MachineUserName + "--- " + MachineIp;

             String s = client.Verifier(year, MachineName, MachineIp, MachineUserName, date);

            label2.Text = s; 

        }
    }
}
