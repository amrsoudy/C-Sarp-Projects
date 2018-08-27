using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            String cs = "server=localhost;user=root;" +
                "database=northwindmysql;port=3306;";
            //obhjet connection 
            MySqlConnection connecection = new MySqlConnection(cs);
            try
            {
                Console.WriteLine("connection sur MySql....");
                connecection.Open();

                //creela requete 
                String query = "SELECT ContactName,CompanyName from customers";
                //preparer lexecution de la requete 
                MySqlCommand sql = new MySqlCommand(query, connecection);

                //recuperer le curser 

                MySqlDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {

                    //afficher détail 
                    String nom, company;
                    nom = (String)reader[0];
                    company = (string)reader[1];

                    Console.WriteLine("nom: {0} - company : {1}", nom, company);




                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally {


                connecection.Close();
            }

        }
    }
}
