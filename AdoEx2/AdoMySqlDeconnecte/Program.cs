using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoMySqlDeconnecte
{
    class Program
    {
        static void Main(string[] args)
        {

            String cs = "server=localhost;user=root;" +
                "database=northwindmysql;port=3306;";

            MySqlConnection connection = new MySqlConnection(cs);
            DataSet ds = new DataSet();
            try
            {

                Console.WriteLine("Manipulation sur MySql.....");
                String query = "SELECT CategoryId ,CategoryName,Description,Picture from Categories";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);

                MySqlCommandBuilder cmdBldr = new MySqlCommandBuilder(da);
                da.Fill(ds, "CategoriesDs");
                Console.WriteLine("ainipulation de la table du dataset");
                DataRow myRow = ds.Tables["CategoriesDs"].NewRow();
                myRow["CategoryName"] = "Machininma";
                myRow["Description"] = "Etude cinma 3D";
                myRow["Picture"] = "Machine.jpg";
                ds.Tables["CategoriesDs"].Rows.Add(myRow);

                foreach (DataColumn column in ds.Tables["CategoriesDs"].Columns)
                    Console.WriteLine("{0}", column.Caption);

                foreach (DataTable maTable in ds.Tables)
                {


                    foreach (DataRow enreg in maTable.Rows)
                    {
                        foreach (DataColumn myColumn in maTable.Columns)
                        {


                            Console.WriteLine(enreg[myColumn]);
                        }


                    }
                }
                Console.WriteLine("Mise a jour de la source a partier du dataset ....");
                da.Update(ds, "CategoriesDs");

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
