using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n6
{
    class Program
    {
        enum x { a, e, i, u };
        static void Main(string[] args)
        {
       
            Console.WriteLine("write un char");
            String s = Console.ReadLine();

            for (int i = 0; i <= 4; i++) {

                string myString =  Enum.GetName(typeof(x), i);

                bool t = Utils.verifi(s, myString);

                if (t == true)
                {

                    Console.WriteLine("le lettre est {0} est  Voyale ", s);
                    break;


                }
                else {

                    Console.WriteLine("le lettre est {0} est  pas  Voyale ", s);
                    break;


                }




            }

          
            


        }
    }
}
