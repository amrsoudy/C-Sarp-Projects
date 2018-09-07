using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
      
            public string Verifier(DateTime d, string MachineName,String MachineIP,String UserName ,DateTime date)
        {

            String s = "";

            int X = d.Year;
            

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
                else {
                    s = "TU DOIT ETRE ENTER 1970 ET 2010  SEULMENT";

                }


            }
            catch (Exception ex)
            {

            }
            SauvgarderBDD(d, MachineName, MachineIP, UserName, date);

            return s;

        }

        public void SauvgarderBDD(DateTime value, string MachineName, string MachineIP, string UserName, DateTime date)
        {
            using (SqlConnection connection =
           new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\1795162\\Documents\\GitHub\\C-Sharp-Projects\\ProjectDeSessionAvecWCF\\BDService.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand command =
                    new SqlCommand("INSERT INTO INFORMATION(ANNE, MACHINENAME, MACHINEIP, USERNAME,CLIENTDATE) " +
                                   "VALUES('" + value + "', '" + MachineName + "', '" + MachineIP + "', '" + UserName + "','" + date + "');"
,
                                   connection);
                connection.Open();
                command.ExecuteNonQuery();



            }
        }

    }
}
