using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet33apourOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int varOut ;
            double resOut ;
            MethodeDeTestOut(out varOut, out resOut);
            Console.WriteLine(varOut);
            Console.ReadKey();

            
        }

        private static void MethodeDeTestOut(out int varOut, out double resOut)
        {

            varOut = 60;
            resOut = 45;
           // Console.WriteLine(varOut);
          //  Console.WriteLine(resOut);



        }
    }
}
