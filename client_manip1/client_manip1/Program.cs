using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cah1_mainp1;

namespace client_manip1
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilaitaires obj = new Utilaitaires();
            double resulte = obj.addition(3.4, 5.0);
            Console.WriteLine(resulte);
            Console.ReadKey();

        }
    }
}
