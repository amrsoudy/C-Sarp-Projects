using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employe emp1 = new Employe("A1","Amr","seoudy","Saint Laurent ");
            Employe emp2 = new Employe("C2","Mazen", "seoudy", "any Laurent ");

            Console.WriteLine(emp1.nom+"   "+emp1.Company);
            Console.WriteLine(emp2.nom+"    "+emp2.Company);
        }
    }
}
