using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithClassStaticSealedAbstracted
{
     class Program :IDisposable
    {

        public readonly String nom = "ssss" ;

         static Program() {

            Console.WriteLine("constracteur donc static class instansier directement quan dtu commance la logicel ");

        }
        ~Program() {

            Console.WriteLine("destrecteur ");


        }
        Program() {
           nom = "Amr ";
            nom = "ggggggg";

            Console.WriteLine("commancer quand on definier la objet de la class ");

        }
          void Main(string[] args)
        {
            using (Program p = new Program()) {
                Console.WriteLine("dans using  ");
               // p.nom = "Amr";
              //  Program.nom = "Amr";
                Console.WriteLine(p.nom);

            }


        }

        public void Dispose() {


            Console.WriteLine("dans dispose  ");


        }
    }

   
}
