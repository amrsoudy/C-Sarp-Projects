using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n8
{
    class Utils
    {
        static Program.date dat = new n8.Program.date();



        public static void demande() {


            Console.WriteLine("ecrire  lanne ");
            bool res = int.TryParse(Console.ReadLine(), out da.annee);
            while (!res)
            {
                Console.WriteLine("ecrire  lanne correctement SVP");
                res = int.TryParse(Console.ReadLine(), out da.annee);

            }
            Console.WriteLine("ecrire  le mois ");
            bool res2 = int.TryParse(Console.ReadLine(), out da.mois);
            while (!res)
            {
                Console.WriteLine("ecrire  mois correctement SVP");
                res = int.TryParse(Console.ReadLine(), out da.mois);

            }
            Console.WriteLine("ecrire  le jour ");
            bool res3 = int.TryParse(Console.ReadLine(), out da.mois);
            while (!res)
            {
                Console.WriteLine("ecrire  jour correctement SVP");
                res3 = int.TryParse(Console.ReadLine(), out da.jour);

            }

           

        }

        internal static void AfficherLaDate()
        {

            Console.WriteLine(dat.annee+"-"+dat.mois+"-"+dat.jour);

        }
    }
}
