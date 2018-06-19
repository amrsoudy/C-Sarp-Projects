using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write any chifre ");
            int num = int.Parse(Console.ReadLine());

            if  (num ==0)
            {

                Console.WriteLine("le num est ni impaire ni pair cest  0 ");

            }

            else if (num % 2 == 0)
            {

                Console.WriteLine("le num est impaire");

            }
            else if (num % 2 == 1)
            {
                Console.WriteLine("le num est paire");
            }
          


        }
    }
}
