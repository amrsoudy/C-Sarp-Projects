using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFunction
{
    class Program :IDisposable
    {
       
        static Program() {

            Console.WriteLine("ctro static");


        }
        ~Program()
        {

            Console.WriteLine("Destrector ");


        }
        Program() {

            Console.WriteLine("ctor defult");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("main");

            using (Program o = new Program()) {

                Console.WriteLine(" using  ");


            };
          //  o.Dispose();


        }

        public void Dispose()
        {
            Console.WriteLine(" dans Dispose  ");
        }
    }
}
