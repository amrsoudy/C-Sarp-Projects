using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using composantassembly;

namespace DeligateCaier6

{
    delegate void delegateSimple();

    class Program
    {
        static void Main(string[] args)
        {

            delegateSimple monDelegate = new delegateSimple(methodeAdeleguer);
            monDelegate();
            Console.ReadKey();
        }
        private static void methodeAdeleguer() {


            Console.WriteLine("vous venez d'utilsier un deleger ");
        }
    }
}
