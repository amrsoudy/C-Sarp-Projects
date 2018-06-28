using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateCaier6No3
{
    class Program
    {
        delegate double delegateParam(double valA, int valB);
        static void Main(string[] args)
        {

            delegateParam sonDelgate = new delegateParam(methodeAdelegateProduite);
            methodeService(sonDelgate, "helloooooooo");
            Console.ReadKey();

        }

        private static double methodeAdelegateProduite(double val1,int val2) {

            Console.WriteLine("Vous avez d'utiliser un delgate ");
            return val1 * val2;

        }

        private static void methodeService(delegateParam p, string txt) {


            Console.WriteLine(txt+" - Le resulte est :{0:f2}",p(10.0,4));


        }
    }
}
