using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierAchatProj
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter le code Article ");
            String code = Console.ReadLine();

            Console.WriteLine("enter le nom d'article ");
            string nom = Console.ReadLine();

            Console.WriteLine("enter la taille de article ");
            string taille = Console.ReadLine();

            Console.WriteLine("Enter le prix ");
            Decimal prix;
            Decimal.TryParse(Console.ReadLine(), out prix);


            PanierAchat pa = new PanierAchat(code, nom, taille, prix);

            Console.WriteLine("==============================");
            Console.WriteLine("Detaille Facturette");
            Console.WriteLine("==============================");

            Console.WriteLine("Item # : " + pa.codeItem);
            Console.WriteLine("Description :  " + pa.nameItem);
            Console.WriteLine("Taille: " + pa.taillItem);
            Console.WriteLine("prix Unitaire : " + pa.priceItem+"$");





        }
    
    }
}
