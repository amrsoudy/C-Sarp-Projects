using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using publiothequeDeAnneDesGens;


namespace ConsoleVerifierAge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String DateComplete;
            int year;
          

            Console.Write("Ecrire la date de naissance SVP dans cette foramte dd-MM-yyyy  : \n" );
         
            DateComplete = Console.ReadLine();
            String[] split = DateComplete.Split('-');
            int.TryParse(split[2], out year);
            Amr_Verification verifi =new Amr_Verification() ;
            String s = verifi.verifier(year);
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
