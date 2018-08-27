using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cahier7a_classes
{
    class BoiteContainer
    {
        private class BoiteInterne {

            public  double longueur;
            public double largeur;

            public double Longueur {

                get { return longueur; }
                set { longueur = value; }

            }
            public double Largeur
            {

                get { return largeur; }
                set { largeur = value; }

            }


        }

        public class prgram
        {
            public  static void Main(string[] args)
            {
                BoiteInterne objMagique = new BoiteInterne();

                objMagique.Longueur = 30;
                objMagique.Largeur = 20;
                Console.WriteLine(objMagique.Longueur+"   "+ objMagique.Largeur);

            }


        }





    }
}
