using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoSqlDeconnecte_Man3
{
    class Program
    {
        static void Main(string[] args)
        {
            String cs = "server=localhost;user=root;" +
           "database=northwindmysql;port=3306;";

            MySqlConnection connection = new MySqlConnection(cs);
            DataSet ds = new DataSet();

            //ajouter la deuxiem table  
            DataTable deptDS = new DataTable();
            ds.Tables.Add(deptDS);

            //ajouter les couonnes
            DataColumn cdeptId = new DataColumn("deptID", typeof(int));
            DataColumn cdeptNom = new DataColumn("deptNom", typeof(string));

            deptDS.Columns.Add(cdeptId);
            deptDS.Columns.Add(cdeptNom);


            //ajouter constraints au clé primere 
            deptDS.Constraints.Add("dept_pk", cdeptId, true);
            cdeptId.AutoIncrement = true;
            cdeptId.AutoIncrementSeed = 10;


            DataRow deptRow = deptDS.NewRow();

            deptRow["deptNom"] = "Comercial";

            deptDS.Rows.Add(deptRow);

            DataRow deptRow2 = deptDS.NewRow();

            deptRow2["deptNom"] = "Techincal";

            deptDS.Rows.Add(deptRow2);

            DataRow[] ligDept = deptDS.Select();



            if (ligDept != null) {

                for (int i = 0 ; i < ligDept.Length; i++){

                    int index;
                    string titre;
                    index = (int)ligDept[i]["deptID"];
                    titre = (string)ligDept[i]["deptNom"];

                    Console.WriteLine("code : {0}  - nom:{1}",index,titre);



                }



            }


            DataTable empDS = new DataTable();
            ds.Tables.Add(empDS);
            //ajouter des coulmn  a la table EMP
            DataColumn cempID = new DataColumn("empID", typeof(int));
            DataColumn cnom = new DataColumn("nom", typeof(string));
            DataColumn cprenom = new DataColumn("prenom", typeof(string));
            DataColumn cage = new DataColumn("age", typeof(int));
            DataColumn cdeotempId = new DataColumn("deptID", typeof(int));

            empDS.Columns.Add(cempID);
            empDS.Columns.Add(cnom);
            empDS.Columns.Add(cprenom);
            empDS.Columns.Add(cage);
            empDS.Columns.Add(cdeotempId);


            empDS.Constraints.Add("un_nom", empDS.Columns["nom"], false);
            empDS.Constraints.Add("pk_empDS", empDS.Columns["empID"], true);

            cempID.AutoIncrement = true;
            cempID.AutoIncrementSeed = 100;

            //ajouter dataRelation enter la table empds et deptds
            DataRelation empDept = new DataRelation("emp_dept_rel", deptDS.Columns["deptID"], empDS.Columns["deptID"], true);
            ds.Relations.Add(empDept);



            //Ajouter records 
            DataRow dr1 = empDS.NewRow();
           
            dr1["nom"] = "Kinslet";
            dr1["prenom"] = "wate";
            dr1["age"] = 23;
            dr1["deptID"] = deptRow["deptID"];

            empDS.Rows.Add(dr1);

            //Ajouter records 
            DataRow dr2 = empDS.NewRow();

            dr2["nom"] = "FlouFlou";
            dr2["prenom"] = "alain";
            dr2["age"] = 35;
            dr2["deptID"] = deptRow2["deptID"];

            empDS.Rows.Add(dr2);


            //Affichage en mode Maitre-détail 
            //lister les employee de chaque dept 
            for (int i = 0; i < deptDS.Rows.Count; i++) {


                Console.WriteLine("---------Departement ode : {0}, nom {1}--------",deptDS.Rows[i]["deptID"],deptDS.Rows[i]["deptNom"]);

                //relation utilise pour cette stucteur maiter_detaill
                DataRow[] empRow = deptDS.Rows[i].GetChildRows("emp_dept_rel");
                //lister les enfans 

                foreach (DataRow drow in empRow) {

                    int index, codeDept ,age;
                    String nom, prenom;
                    index = (int)drow["empID"];
                    age = (int)drow["age"];
                    nom = (String)drow["nom"];
                    prenom = (String)drow["prenom"];
                    codeDept = (int)drow["deptID"];

                    Console.WriteLine("code: {0} - nom : {1} -prenome : {2} - age:  {3} - dept : {4}", index, nom, prenom, age, codeDept);




                }
            }



        }
    }
}
