using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs =
    "Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)" +
    "(HOST = oracleadudb1.bdeb.qc.ca)(PORT = 1521))) (CONNECT_DATA = (SERVICE_NAME = GDNA10) ));" +
"User Id=ug235e27;Password=H4ghuy;";



            OracleConnection connection = new OracleConnection();
            connection.ConnectionString = cs;

            try
            {

                Console.WriteLine("connection vers oracle ");
                connection.Open();
                Console.WriteLine("connected");
                String query = "SELECT last_name,first_name from employees";
                OracleCommand sql = new OracleCommand();
                sql.Connection = connection;
                sql.CommandText = query;
                sql.CommandType = System.Data.CommandType.Text;

                // 
                OracleDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {


                    String nom, prenom;
                    nom = (String)reader[0];
                    prenom = (String)reader[1];
                    Console.WriteLine("nom : {0} - prenom : {1}", nom, prenom);
                }


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
            finally {

                connection.Close();
            }
        }
    }
}
