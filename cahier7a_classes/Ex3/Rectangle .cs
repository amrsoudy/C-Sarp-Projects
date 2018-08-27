using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Rectangle
    {
        public readonly double longueur = 30;
        public readonly double largeur;

        

        public Rectangle() {


            this.largeur = 20;
        }
        public Rectangle(double a , double b )
        {

            this.longueur = a; 
            this.largeur = b;
        }



    }

    class main {

        public static void Main(String[] args) {

            Rectangle objRect1 = new Rectangle(40, 30);
            Rectangle objRect2 = new Rectangle();
            // objRect2.longueur = 60;

            Console.WriteLine(objRect1.longueur + "   " + objRect1.largeur);
            Console.WriteLine(objRect2.longueur + "   " + objRect2.largeur);




        }


    }
}
