using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSeries6n1
{

    class Program
    {
        delegate List<int> delgateparm(List<int> list);

        static void Main(string[] args)
        {


            delgateparm delegate1 = new delgateparm(methodeAdelgatepaire);
            methodeService(delegate1, "paire ");

            delgateparm delegate2 = new delgateparm(methodeAdelgateimpaire);
            methodeService(delegate2, "impaire");

            delgateparm delegate3 = new delgateparm(methodeAdelgateSupDe5);
            methodeService(delegate3, "superier de 5");

            Console.ReadKey();

        }
        private static List<int> methodeAdelgatepaire(List<int> list)
        {
            List<int> listPaires = new List<int>();


            foreach (int i in list)
            {
                if (i % 2 == 0)
                    listPaires.Add(i);

            }

            return listPaires;
        }

        private static List<int> methodeAdelgateimpaire(List<int> list)
        {
            List<int> listimPaires = new List<int>();


            foreach (int i in list)
            {
                if (i % 2 == 1)
                    listimPaires.Add(i);

            }

            return listimPaires;
        }
        private static List<int> methodeAdelgateSupDe5(List<int> list)
        {
            List<int> listSupDe5 = new List<int>();


            foreach (int i in list)
            {
                if (i > 5)
                    listSupDe5.Add(i);

            }

            return listSupDe5;
        }
        private static void methodeService(delgateparm p, String txt)
        {
            List<int> list = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });


            foreach (int i in p(list))
            {

                Console.WriteLine(txt + " - Le resulte est :{0:f2}", i);


            }

            Console.WriteLine("-------------------------------------------------");




        }


    }
}
