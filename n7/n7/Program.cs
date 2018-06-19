using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n7
{
    class Program
    {
        public struct fact
        {
            public int no;
            public int NoTotal;
            public string nom;
            public double prix;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("ecrire le no d,Article");
            fact F = new fact();
            F.no = int.Parse(Console.ReadLine());

            Console.WriteLine("ecrire le nom d article ");
            F.nom = Console.ReadLine();

            Console.WriteLine("ecrire le NoTotal d article ");

            F.NoTotal = int.Parse(Console.ReadLine());

            Console.WriteLine("ecrire le prix Svp");
            F.prix = double.Parse(Console.ReadLine());


            Utils.remplier(F);
            Utils.afficher();




            Utils.afficherTotal();


        }
    }
}
