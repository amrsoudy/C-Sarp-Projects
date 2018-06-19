using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n7
{
    class Utils 
    {
        public static List<Program.fact> list = new List<Program.fact>();

        internal static void remplier(object f)
        {


            list.Add((Program.fact)f);
        }

        internal static void afficher() {


            foreach (Program.fact p in list) {

               


                Console.WriteLine(p.no +"      "+ p.nom +"    "+ p.prix +"    "+ p.NoTotal);



            }

        }

        internal static void afficherTotal()
        {
            foreach (Program.fact p in list)
            {

                Console.WriteLine(p.no + "      " + p.nom + "    " + "Total  prix "+(p.prix * p.NoTotal));



            }

        }
    }
    }

