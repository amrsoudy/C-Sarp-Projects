using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WCFClientConsole.ServiceReference1;

namespace WCFClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");


            String MachineName = System.Environment.MachineName;
            String MachineUserName = System.Environment.UserName;
            String MachineIp = Dns.GetHostAddresses(MachineName)[0].ToString();

            DateTime date = DateTime.Now;

            Console.WriteLine("SVP Ecrire ton date en Formate yyyy-MM-dd");
            String leDate = Console.ReadLine();

            DateTime DateComplete = DateTime.Parse(leDate);



            String s = client.Verifier(DateComplete, MachineName, MachineIp, MachineUserName, date);

            Console.WriteLine(s);
            Console.ReadKey();
                }
    }
}
