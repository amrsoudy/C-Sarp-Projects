using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventEtLesDelegates
{
    class Driver
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();

            Observer1 obs1 = new Observer1();

            pub.ValeurTemperatureChange += new MonDelegue(obs1.EcrireEcran);

            Console.WriteLine("sasier une valeur ");
            int valeur = Int16.Parse(Console.ReadLine());
            pub.notifier(valeur);

            Console.ReadKey();

        }
    }
}
