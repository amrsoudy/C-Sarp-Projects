using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXRevIntra_IMG
{
    class Utils
    {
        Form1 form1 = Form1.getInstance();

        private static Utils util;

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

        public Boolean verifi()
        {

            Boolean status1 = false;
            Boolean status2 = false;
            Boolean status3 = false;
            Boolean status4 = false;




            if (!Regex.IsMatch(form1.textBox1.Text, @"[a-zA-Z]+$"))
            {

                form1.textBox1.ForeColor = Color.DarkRed;
                form1.labelText1.Text = "SVP  verifi le Nom (il dois  inclue Letter seulement )";

            }
            else
            {
                form1.labelText1.Text = "";
                status1 = true;
            }

            if (!Regex.IsMatch(form1.textBox2.Text, @"[0-9]+$"))
            {

                form1.textBox2.ForeColor = Color.DarkRed;
                form1.labelText2.Text = "SVP  verifi le Nom (il dois  inclue numbers seulement )";

            }
            else
            {
                form1.labelText2.Text = "";
                status2 = true;
            }
            if (!Regex.IsMatch(form1.textBox3.Text, @"[0-9]+$"))
            {

                form1.textBox3.ForeColor = Color.DarkRed;
                form1.labelText3.Text = "SVP  verifi le Nom (il dois  inclue numbers seulement )";

            }
            else
            {
                form1.labelText3.Text = "";
                status3 = true;
            }
            if (!Regex.IsMatch(form1.textBox4.Text, @"[0-9]+$"))
            {

                form1.textBox4.ForeColor = Color.DarkRed;
                form1.labelText4.Text = "SVP  verifi le Nom (il dois  inclue numbers seulement)";

            }
            else
            {
                form1.labelText4.Text = "";
                status4 = true;
            }

            if ((status1 = true) && (status2 = true) && (status3 = true) && (status4 = true))
            {


                return true;

            }
            else
            {


                return false;
            }
        }

        public void calculer()
        {
            Boolean status = verifi();
            MessageBox.Show(status.ToString() + " verifi");
            if (status)
            {

                Boolean statusNUMBERS = VERIFINUMBER();
                MessageBox.Show(statusNUMBERS.ToString());
                if (statusNUMBERS)
                {


                }


            }
            else
            {


                MessageBox.Show("here");


            }

        }

        private Boolean VERIFINUMBER()
        {
            double taille;
            int age;
            int masse;
            Boolean status = false;
            if (!double.TryParse(form1.textBox2.Text, out taille))
            {
                form1.textBox2.Focus();

                form1.labelText2.Text = "le taille dois etre dans cette formatte  #.##";


            }
            else
            {
                if (taille > 3.0)
                {

                    form1.textBox2.Focus();
                    form1.labelText2.Text = "le taille doit etre moin de 3.5 metter ";

                }
                else
                {

                    if (!int.TryParse(form1.textBox3.Text, out masse))
                    {

                        form1.textBox3.Focus();
                        form1.labelText3.Text = "le masse doit etre comme cette formate ###";



                    }
                    else
                    {

                        if (masse > 500)
                        {

                            form1.textBox3.Focus();
                            form1.labelText3.Text = "le masse doit etre moin de 500";


                        }
                        else
                        {
                            if (!int.TryParse(form1.textBox4.Text, out age))
                            {

                                form1.textBox4.Focus();
                                form1.labelText2.Text = "le taille dois etre dans cette formatte  ##";


                            }
                            else
                            {

                                if (age > 99)
                                {

                                    form1.textBox4.Focus();
                                    form1.labelText2.Text = "le taille dois etre dans cette formatte  ##  2 Digit seulment";


                                }
                                else
                                {


                                    if (!form1.radioButton1.Checked || !form1.radioButton2.Checked)
                                    {

                                        form1.labelText5.Text = "Svp Choisir Femme ou Homme ";

                                    }
                                    else
                                    {

                                        status = true;



                                    }

                                }



                            }

                        }
                    }
                }
            }
            return status;
        }
    }
}
