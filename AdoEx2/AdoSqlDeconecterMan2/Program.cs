using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSqlDeconecterMan2
{
    class Program
    {
        static void Main(string[] args)
        {

            String cs = "server=localhost;user=root;" +
                "database=northwindmysql;port=3306;";

            MySqlConnection connection = new MySqlConnection(cs);
            //creationg une table 
            DataTable empDS;
            empDS = new DataTable("EMP");


            DataSet ds = new DataSet();
            ds.Tables.Add(empDS);
            //ajouter des coulmn  a la table EMP
            DataColumn cempID = new DataColumn("empID", typeof(int));
            DataColumn cnom = new DataColumn("nom", typeof(string));
            DataColumn cprenom = new DataColumn("prenom", typeof(string));
            DataColumn cage = new DataColumn("age", typeof(int));

            empDS.Columns.Add(cempID);
            empDS.Columns.Add(cnom);
            empDS.Columns.Add(cprenom);
            empDS.Columns.Add(cage);

            //Ajouter records 
            DataRow drl = empDS.NewRow();
            drl["empID"] = 100;
            drl["nom"] = "Seoudy";
            drl["prenom"] = "Amr";
            drl["age"] = 36;

            empDS.Rows.Add(drl);

            //cree raquete  
            String where = "nom like 'Se%'";
            DataRow[] lignes = empDS.Select(where);

            if (lignes != null)
            {

                for (int i = 0; i < lignes.Length; i++)
                {
                    int index, age;
                    String nom, prenom;
                    index = (int)lignes[i]["empID"];
                    age = (int)lignes[i]["age"];
                    nom = (String)lignes[i]["nom"];
                    prenom = (String)lignes[i]["prenom"];
                    //  Console.WriteLine("code: {0} - nom : {1} - prenom : {2} -age: {3}", index, nom, prenom, age);

                }


            }
            //ajouter clé unique  si false just unique column 
            empDS.Constraints.Add("un_nom", empDS.Columns["nom"], false);

            //verification que la clé est bien en fonction 
                //DataRow dr3 = empDS.NewRow();
                //dr3["empID"] = 102;
                //dr3["nom"] = "Seoudy";
                //dr3["prenom"] = "Mazen";
                //dr3["age"] = 8;
                //empDS.Rows.Add(dr3);

            //ajout de clé primaire  si true  primary key
            empDS.Constraints.Add("pk_empDS", empDS.Columns["empID"], true);

            //indiquer que colonne auto_incremntal 
            cempID.AutoIncrement = true;
            cempID.AutoIncrementSeed = 103;

            DataRow dr4 = empDS.NewRow();
          
            dr4["nom"] = "ClairFlou";
            dr4["prenom"] = "Tango";
            dr4["age"] = 125;
            empDS.Rows.Add(dr4);


            DataRow[] lignes2 = empDS.Select();

            if (lignes2 != null) {


                for(int i = 0; i < lignes2.Length; i++)
                {

                    int index, age;
                    String nom, prenom;
                    index = (int)lignes2[i]["empID"];
                    age = (int)lignes2[i]["age"];
                    nom = (String)lignes2[i]["nom"];
                    prenom = (String)lignes2[i]["prenom"];
                    Console.WriteLine("code22222: {0} - nom : {1} - prenom : {2} -age: {3}", index, nom, prenom, age);


                }




            }



        }
    }
}
