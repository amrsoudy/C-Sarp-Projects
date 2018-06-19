using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n8
{
    class Utils
    {
        static Program.date dat = new n8.Program.date();



        public static void demande()
        {


            Console.WriteLine("ecrire  lanne ");
            bool res = int.TryParse(Console.ReadLine(), out dat.annee);
            while (!res)
            {
                Console.WriteLine("ecrire  lanne correctement SVP");
                res = int.TryParse(Console.ReadLine(), out dat.annee);

            }
            Console.WriteLine("ecrire  le mois ");
            bool res2 = int.TryParse(Console.ReadLine(), out dat.mois);
            while (!res2)
            {
                Console.WriteLine("ecrire  mois correctement SVP");
                res2 = int.TryParse(Console.ReadLine(), out dat.mois);

            }
            Console.WriteLine("ecrire  le jour ");
            bool res3 = int.TryParse(Console.ReadLine(), out dat.jour);
            while (!res3)
            {
                Console.WriteLine("ecrire  jour correctement SVP");
                res3 = int.TryParse(Console.ReadLine(), out dat.jour);

            }




        }



        internal static void AfficherLaDate()
        {

            Console.WriteLine(dat.annee + "-" + dat.mois + "-" + dat.jour);

        }
        internal static void afficheNextJour()
        {
            Program.date nextDate = new Program.date();

            if (dat.annee > 0)
            {
                double b = dat.annee % 400;
                double r = b % 100;

                Console.WriteLine(b);
                Console.WriteLine(r);
                Console.WriteLine(r%4);


                bool yearComplex;
                if (b == 0)
                {

                    yearComplex = false;
                }
                else if (r == 0)
                {
                    yearComplex = true;
                    // not complex



                }
                else if (r % 4 == 0)
                {
                    yearComplex = false;



                }
                else
                {

                    yearComplex = true;


                }

                if (yearComplex)
                {

                    Console.WriteLine("l'anne est bissextile");

                }
                else {

                    Console.WriteLine("l'anne est pas bissextile");


                }


                if (dat.mois > 0 && dat.mois <= 12)
                {
                    if (dat.jour > 0)
                    {
                        if (dat.mois == 01 || dat.mois == 03 || dat.mois == 05 || dat.mois == 07 || dat.mois == 08 || dat.mois == 10 || dat.mois == 12)
                        {


                            if (dat.jour < 31)
                            {

                                nextDate.annee = dat.annee;
                                nextDate.mois = dat.mois;
                                nextDate.jour = dat.jour + 1;
                            }
                            else if (dat.mois < 12)
                            {

                                nextDate.annee = dat.annee;
                                nextDate.mois = dat.mois + 1;
                                nextDate.jour = 1;


                            }
                            else if (dat.mois == 12)
                            {
                                nextDate.annee = dat.annee + 1;
                                nextDate.mois = 1;
                                nextDate.jour = 1;


                            }
                        }
                        else if (dat.mois == 04 || dat.mois == 06 || dat.mois == 09 || dat.mois == 11)
                        {


                            if (dat.jour < 30)
                            {

                                nextDate.annee = dat.annee;
                                nextDate.mois = dat.mois;
                                nextDate.jour = dat.jour + 1;
                            }
                            else if (dat.jour == 30)
                            {
                                nextDate.annee = dat.annee;
                                nextDate.mois = dat.mois + 1;
                                nextDate.jour = 1;

                            }


                        }
                        else if (dat.mois == 02)
                        {
                            if (yearComplex == true)
                            {

                                if (dat.jour < 28)
                                {

                                    nextDate.annee = dat.annee;
                                    nextDate.mois = dat.mois;
                                    nextDate.jour = dat.jour + 1;
                                }
                                else if (dat.jour == 28)
                                {
                                    nextDate.annee = dat.annee;
                                    nextDate.mois = dat.mois + 1;
                                    nextDate.jour = 1;

                                }

                            }
                            else
                            {

                                if (dat.jour < 29)
                                {

                                    nextDate.annee = dat.annee;
                                    nextDate.mois = dat.mois;
                                    nextDate.jour = dat.jour + 1;
                                }
                                else if (dat.jour == 29)
                                {
                                    nextDate.annee = dat.annee;
                                    nextDate.mois = dat.mois + 1;
                                    nextDate.jour = 1;

                                }

                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("tu doit ecrire number da jour positive SVP");
                    }
                }
                else
                {
                    Console.WriteLine("tu doit ecrire number da Mois  positive SVP");


                }
            }
            else
            {
                Console.WriteLine("tu doit ecrire number da annee  positive SVP");


            }


            Console.WriteLine(nextDate.annee +"-"+ nextDate.mois+"-"+ nextDate.jour);
        }

        public static void afficherlaDay() {

            CultureInfo ci = new CultureInfo("fr-FR") ;
          


            if (ci.Name == "fr-FR")
            {


                }
                string stringValue = Enum.GetName(typeof(DayOfWeek), dat.jour);

                Console.WriteLine(stringValue);


            }


        }
    }
}
