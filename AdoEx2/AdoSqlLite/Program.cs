using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdoSqlLite
{
    class Program
    {
        public static object SqlliteConnection { get; private set; }

        static void Main(string[] args)
        {
            SQLiteConnection connection =
                new SQLiteConnection(@"Data Source=C:\Users\1795162\Documents\GitHub\C-Sharp-Projects\utilitaire\sqlite\sqlitenorthwind.s3db");


            try {

                Console.WriteLine("Connection sur SqlLite");
                connection.Open();

                String query = "select categoryID,description from categories";
                SQLiteCommand sql = new SQLiteCommand(query,connection);
                SQLiteDataReader reader = sql.ExecuteReader();

                while (reader.Read()) {

                    String description;
                    int id;
                    id = Convert.ToInt32(reader[0]);
                    description = (String)reader[1];
                    Console.WriteLine("categore : {0}   -  Description : {1}", id, description);

                }

               


            } catch (Exception e) {




            }
        }
    }
}
