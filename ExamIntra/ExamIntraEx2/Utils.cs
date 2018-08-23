using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamIntraEx2
{
    class Utils
    {
        private static Utils util;

        Form1 form1 = Form1.getInstance();
        private double _remb;
        public double _mountant ;
        public double _Costisation ;
        private String _Nom;
        private String _Prenom;
        private String _corriel;


      
        public String Nom
        {

            get { return _Nom; }
            set { _Nom = value; }

        }
        public String Prenom
        {

            get { return _Prenom; }
            set { _Prenom = value; }

        }
        public String corrial
        {

            get { return _corriel; }
            set { _corriel = value; }

        }
        public double Remb
        {

            get { return _remb; }
            set { _remb = value; }

        }



        public static Utils getInstance()
        {

            if (util == null)
            {
                util = new Utils();
                return util;
            }
            else
            {

                return util;
                
             
            }


        }



        private Boolean Verifie()
        {
            Boolean status1 = false;
            Boolean status2 = false;
            Boolean status3 = false;
            Boolean status4 = false;
            Boolean status5 = false;


            

            //verifi si  le nom ne inclue pas numbers ou autre  
            if ((!Regex.IsMatch(form1.textBox1.Text, @"[a-zA-Z]+$")))
            {

                form1.textBox1.ForeColor = Color.DarkRed;
                form1.label6.Text = "SVP  verifi le Nom (il dois  inclue Letter seulement )";

            }
            else
            {
                form1.label6.Text = "";

                Nom = form1.textBox1.Text;

                status1 = true;
            }
            //verifi si  le prenom ne inclue pas numbers ou autre  

            if (!Regex.IsMatch(form1.textBox2.Text, @"[a-zA-Z]+$"))
            {

                form1.textBox2.ForeColor = Color.DarkRed;
                form1.label7.Text = "SVP  verifi le préNom (il dois  inclue Letter seulement )";

            }
            else
            {
                form1.label7.Text = "";
                Prenom = form1.textBox2.Text;
                status2 = true;
            }
            //verifi si le corrial respecter lettre et numiric et  _ - " .
            if (!Regex.IsMatch(form1.textBox3.Text, @"[a-zA-Z0-9_@.-]+$"))
            {

                form1.textBox3.ForeColor = Color.DarkRed;
                form1.label8.Text = "SVP  verifi le Courriel ";

            }
            else
            {
                form1.label8.Text = "";
                corrial = form1.textBox3.Text;
                status3 = true;
            }
            if (!Regex.IsMatch(form1.textBox4.Text, @"[0-9]+$"))
            {

                form1.textBox4.ForeColor = Color.DarkRed;
                form1.label9.Text = "SVP  verifi le Mountant (il dois  inclue numbers seulement )";

            }
            else
            {
                form1.label9.Text = "";
                status4 = true;
            }
            if (!Regex.IsMatch(form1.textBox4.Text, @"[0-9]+$"))
            {

                form1.textBox5.ForeColor = Color.DarkRed;
                form1.label10.Text = "SVP  verifi le Cotisation (il dois  inclue numbers seulement)";

            }
            else
            {
                form1.label10.Text = "";
                status5 = true;
            }

            if ((status1 = true) && (status2 = true) && (status3 = true) && (status4 = true) && (status5 = true))
            {


                return true;

            }
            else
            {


                return false;
            }


        }
        //pour calculer le remborsement
        internal void calculer()
        {
            //veifi si tous le champ  valid et pas vide 
            Boolean status = Verifie();
            
            Boolean stautsDesNumbers;

            if (status)
            {
                //verifi si les numbers bien 
                stautsDesNumbers = VerifiLesNumbers();
                if (stautsDesNumbers)
                {

                    Remb = _mountant * 0.15 - _Costisation;
                    form1.Visible = false;
                    Form2.getInstance().Show();

                }

            }
        }

        private bool VerifiLesNumbers()
        {
            Boolean status = false;

            if (!double.TryParse(form1.textBox4.Text, out _mountant))

            {
                form1.textBox2.Focus();

                form1.label9.Text = "le Mountant pas correct";


            }
            else
            {
                if (_mountant < 0)
                {

                    form1.textBox2.Focus();

                    form1.label9.Text = "le Mountant peut pas etre negative";


                }
                else
                {
                    form1.label9.Text = "";

                    if (!double.TryParse(form1.textBox5.Text, out _Costisation))

                    {
                        form1.textBox5.Focus();

                        form1.label10.Text = "le Costisation pas correct";


                    }
                    else
                    {
                        if (_Costisation < 0) {


                            form1.textBox5.Focus();

                            form1.label10.Text = "le Costisation peut pas etre negative ";

                        }
                        else {
                        form1.label10.Text = "";

                        status = true;




                    }
                }
               

            }
            }
            return status;
        }
    }
}