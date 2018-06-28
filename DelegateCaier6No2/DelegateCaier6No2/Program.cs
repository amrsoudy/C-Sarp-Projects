using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCaier6No2
{

    delegate double delegateAvance(double valA, int valB);
    class Program
    {
        static void Main(string[] args)
        {

            delegateAvance tonDelegate = new delegateAvance(methodeAdelegateProduit);

            Console.WriteLine("le resulté est :{0:f2}",tonDelegate(10.0,4));
            Console.ReadKey();

        }

        private static double methodeAdelegateProduit(double val1, int val2) {

            return val1 * val2;
        }


    }
}
