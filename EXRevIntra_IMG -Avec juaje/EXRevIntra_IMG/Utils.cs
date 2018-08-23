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
        double taille;
        int age;
        int masse;
        int sex;
        double img;

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

                if (statusNUMBERS)
                {

                    img = Math.Round((1.2 * masse / (taille * taille)) + (0.23 * age) - (10.8 * sex) - 5.4);
                    //notify la pubisher
                    Publisher.getInstance().notify(img);


                   // form1.textBox6.Text = img.ToString("#.0");

                    if (sex == 0)
                    {

                        if (img < 25)
                        {

                            form1.textBox7.Text = "trop maigre";

                        }
                        else if (img < 30)
                        {
                            form1.textBox7.Text = "normal";


                        }
                        else if (img > 30)
                        {

                            form1.textBox7.Text = "trop de grasse";


                        }


                    }



                }
                else if (sex == 1)
                {

                    if (img < 15)
                    {
                        form1.textBox7.Text = "trop maigre";


                    }
                    else if (img < 20)
                    {

                        form1.textBox7.Text = "normal";

                    }
                    else if (img >= 20)
                    {

                        form1.textBox7.Text = "trop de grasse";


                    }




                }


            }

        }



        private Boolean VERIFINUMBER()
        {

            Boolean status = false;

            if (!double.TryParse(form1.textBox2.Text.Replace('.', ','), out taille))

            {
                form1.textBox2.Focus();

                form1.labelText2.Text = "le taille dois etre dans cette formatte  #.##";


            }
            else
            {
                String[] s = taille.ToString().Split(',');
                int number = s[1].Length;
                MessageBox.Show(number.ToString());
                if (number > 2)
                {

                    form1.textBox2.Focus();
                    form1.labelText2.Text = "le taille doit avec 2 digit apre le point selemnet  ";

                }
                else
                {

                    form1.labelText2.Text = "";
                    if (taille > 3.0 || taille < 0)
                    {

                        form1.textBox2.Focus();
                        form1.labelText2.Text = "le taille doit etre moin de 3.5 metter ";

                    }
                    else
                    {


                        form1.labelText2.Text = "";
                        if (!int.TryParse(form1.textBox3.Text, out masse))
                        {

                            form1.textBox3.Focus();
                            form1.labelText3.Text = "le masse doit etre comme cette formate ###";



                        }
                        else
                        {
                            form1.labelText3.Text = "";

                            if (masse > 200 || masse < 0)
                            {

                                form1.textBox3.Focus();
                                form1.labelText3.Text = "le masse doit etre moin de 500";


                            }
                            else
                            {
                                form1.labelText3.Text = "";
                                if (!int.TryParse(form1.textBox4.Text, out age))
                                {

                                    form1.textBox4.Focus();
                                    form1.labelText2.Text = "le taille dois etre dans cette formatte  ##";


                                }
                                else
                                {
                                    form1.labelText2.Text = "";
                                    if (age < 15 || age > 50)
                                    {

                                        form1.textBox4.Focus();
                                        form1.labelText4.Text = "l age doit etre enter 15 et 50 ";


                                    }
                                    else
                                    {
                                        form1.labelText4.Text = "";

                                        MessageBox.Show(form1.radioButton1.Checked.ToString() + " cheking 1 ");
                                        MessageBox.Show(form1.radioButton2.Checked.ToString() + " cheking 2 ");

                                        if ((form1.radioButton1.Checked) || (form1.radioButton2.Checked))
                                        {
                                            status = true;
                                            if (form1.radioButton1.Checked)
                                            {

                                                sex = 0;
                                            }
                                            else
                                            {


                                                sex = 1;
                                            }


                                        }
                                        else
                                        {

                                            form1.labelText5.Text = "Svp Choisir Femme ou Homme ";



                                        }

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
