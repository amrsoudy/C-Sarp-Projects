using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3aExparValeurouParRef
{
    class ExparValeurouParRef
    {
        static void Main(string[] args)
        {

           ref int varEntree = 10;

            Console.WriteLine(varEntree);

           //MethodeDeTestParameter(varEntree);

            MethodeDeTestParameter(varEntree);

            Console.WriteLine(varEntree);



        }

       // public static int MethodeDeTestParameter(int varEntree)

        public static int MethodeDeTestParameter(ref int varEntree)
        {

            return varEntree += 45;
        }
    }
}



