using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ecrire  comme tu veut number");
            double num = double.Parse(Console.ReadLine());

            double num2 = Utils.calcul(num);

            Console.WriteLine("le caree  est  :  "+num2);



            
        }
    }
}
