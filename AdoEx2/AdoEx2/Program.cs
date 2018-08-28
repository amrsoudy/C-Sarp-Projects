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
            MySqlDataReader reader = null;
            try
            {
                Console.WriteLine("connection sur MySql....");
                connecection.Open();

                ////creela requete 
                //String query = "SELECT ContactName,CompanyName from customers";
                ////preparer lexecution de la requete 
                //MySqlCommand sql = new MySqlCommand(query, connecection);

                ////recuperer le curser 

                // reader = sql.ExecuteReader();

                //while (reader.Read())
                //{

                //    //afficher détail 
                //    String nom, company;
                //    nom = (String)reader[0];
                //    company = (string)reader[1];

                //    Console.WriteLine("nom: {0} - company : {1}", nom, company);

                //}
                //String queryInsert = "insert into 	categories (CategoryName,Description,Picture) values ('sport','Tous les articles de sport','sport.gif')";
                //MySqlCommand sql2 = new MySqlCommand(queryInsert, connecection);
                //sql2.ExecuteNonQuery();

                //String queryUpdate = "update categories  set Description = 'Tous les articles de sport 2010',Picture = 'sportage.gif'  where CategoryName = 'sport' ";
                //MySqlCommand sql3 = new MySqlCommand(queryUpdate, connecection);
                //sql3.ExecuteNonQuery();

                //String queryDelete = "delete from categories where CategoryName = 'sport'  ";
                //MySqlCommand sql4 = new MySqlCommand(queryDelete, connecection);
                //sql4.ExecuteNonQuery();

                //String queryMax = "select MAX(UnitPrice) from  products ";
                //MySqlCommand sql5 = new MySqlCommand(queryMax, connecection);
                //double no = (double)sql5.ExecuteScalar();
                //Console.WriteLine(no.ToString());

                //String querySum = "select SUM(UnitPrice) from  products ";
                //MySqlCommand sql6 = new MySqlCommand(querySum, connecection);
                //double no2 = (double)sql6.ExecuteScalar();
                //Console.WriteLine(no2.ToString());



                //String queryMin = "select Min(UnitPrice) from  products ";
                //MySqlCommand sql7 = new MySqlCommand(queryMin, connecection);
                //double no3 = (double)sql7.ExecuteScalar();
                //Console.WriteLine(no3.ToString());

                //String reqSelect = "select ProductName ,UnitPrice from products where ProductName like @nomproduit";
                String reqSelect = "select ProductName ,UnitPrice from products where ProductName like @nomproduit And UnitPrice > @prix ";

                Console.Write("saiser le nom du produit : ");
                String nomprd = Console.ReadLine();
                Console.Write("Saiser le prix de commencer ");
                double prixDemande;

                double.TryParse(Console.ReadLine(), out prixDemande);

                MySqlParameter parameter = new MySqlParameter();
                parameter.ParameterName = "@nomproduit";
                parameter.Value = "%"+nomprd+"%";

                MySqlParameter parameter2 = new MySqlParameter();

                parameter2.ParameterName = "@prix";
                parameter2.Value = prixDemande;



                MySqlCommand sql = new MySqlCommand(reqSelect, connecection);
                sql.Parameters.Add(parameter);
                sql.Parameters.Add(parameter2);


                reader = sql.ExecuteReader();

                while (reader.Read()) {

                    String nom = (string)reader[0];
                    double prix = Convert.ToDouble(reader[1]);
                    Console.WriteLine("nom est : {0} - et prix est : {1}", nom, prix);


                }
               


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally {

                if (reader != null) reader.Close();

                if(connecection !=null)

                connecection.Close();
            }

        }
    }
}
