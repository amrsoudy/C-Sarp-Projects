using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        public void SauvgarderBDD(int value, string MachineName, string MachineIP, string UserName, DateTime date)
        {
           

        }

        public string Verifier(int X, string MachineName,String MachineIP,String UserName ,DateTime date)
        {

            String s = "";

            try
            {

                if (X <= 1970)
                {
                    s = " il est le temp d.aller se promener a travers le monde ";

                }
                else if (X >= 1971 && X <= 1980)
                {

                    s = "il est temps de commencer a travailler sérieusement";
                }
                else if (X >= 1981 && X <= 1990)
                {

                    s = "il est grand temps de terminer tes études !";
                }
                else if (X >= 1991 && X <= 2000)
                {

                    s = "Faire ce qui te plait ; ti as encoure le temps !";
                }
                else if (X >= 2001 && X <= 2010)
                {

                    s = "Utilisation de service non autorisee!";
                }


            }
            catch (Exception ex)
            {

            }

            return s;
            SauvgarderBDD( X,  MachineName,  MachineIP,  UserName,  date);

        }
    }
}
