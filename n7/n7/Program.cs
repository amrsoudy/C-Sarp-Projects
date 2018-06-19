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
            int j;
            Console.WriteLine("ecrire le no total  des Articles");
            
             bool res0 = int.TryParse(Console.ReadLine(),out  j);

            while (!res0) {
                Console.WriteLine("ecrire le no total  des Articles correct SVP");

                res0 = int.TryParse(Console.ReadLine(), out j);

            }

            if (j > 0)
            {

                for (int i = 0; i < j; i++)
                {

                    fact F = new fact();
                    Console.WriteLine("ecrire le no d,Article  ");

                    bool res = int.TryParse(Console.ReadLine(), out F.no);
                    while (!res)
                    {
                        Console.WriteLine("ecrire le no d,Article autre fois ");
                        res = int.TryParse(Console.ReadLine(), out F.no);
                    }

                    Console.WriteLine("ecrire le nom d article ");
                    F.nom = Console.ReadLine();

                    Console.WriteLine("ecrire le NoTotal d article ");

                    bool res2 = int.TryParse(Console.ReadLine(), out F.NoTotal);

                    while (!res2)
                    {
                        Console.WriteLine("ecrire le NoTotal d article  correst svp ");
                        res2 = int.TryParse(Console.ReadLine(), out F.NoTotal);

                    }

                    Console.WriteLine("ecrire le prix Svp");
                   bool res3 = double.TryParse(Console.ReadLine(), out F.prix);

                    while (!res3) {
                        Console.WriteLine("ecrire le prix Svp correct  svp ");
                        res3 = double.TryParse(Console.ReadLine(), out F.prix);

                    }


                    Utils.remplier(F);
                    Utils.afficher();


                }

                Console.WriteLine("*****************************************************");
                Utils.afficherTotal();

            }
            else
            {


                Console.WriteLine(" le  no  d article doit etre positive plus de 0 ");

            }








        }
    }
}
