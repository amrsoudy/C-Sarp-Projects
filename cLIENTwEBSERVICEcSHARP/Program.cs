using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cLIENTwEBSERVICEcSHARP.ServiceReference1;
namespace cLIENTwEBSERVICEcSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1SoapClient PROXY = new Service1SoapClient();

            double res =PROXY.calculersupstraction(56, 3);
            Console.WriteLine(res);
        }
    }
}
