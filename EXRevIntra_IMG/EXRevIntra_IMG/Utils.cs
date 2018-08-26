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

        private static Utils util;

        public static Utils getInstance() {

            if (util == null)
            {

                util = new Utils();
                return util;


            }
            else {

                return util; 

            }


        }

        public Boolean verifi() {

            Form1 form1 = Form1.getInstance();
            Boolean status = false;



            if (!Regex.IsMatch(form1.textBox1.Text, @"[a-zA-Z]+$"))
            {

                form1.textBox1.ForeColor = Color.DarkRed;
                form1.labelText1.Text = "SVP  verifi le Nom (il dois  inclue Letter seulement )";

            }
            else
            {
                form1.labelText1.Text = "";
                status = true;
            }
            
              if (!Regex.IsMatch(form1.textBox2.Text, @"[0-9]+$"))
            {

                form1.textBox2.ForeColor = Color.DarkRed;
                form1.labelText2.Text = "SVP  verifi le Nom (il dois  inclue numbers seulement )";

            }
            else if (!Regex.IsMatch(form1.textBox3.Text, @"[0-9]+$"))
            {

                form1.textBox3.ForeColor = Color.DarkRed;
                form1.labelText3.Text = "SVP  verifi le Nom (il dois  inclue numbers seulement )";

            }
            else if (!Regex.IsMatch(form1.textBox4.Text, @"[0-9]+$"))
            {

                form1.textBox4.ForeColor = Color.DarkRed;
                form1.labelText4.Text = "SVP  verifi le Nom (il dois  inclue numbers seulement )";

            }
            


            return status;
        }

        internal void calculer()
        {
            throw new NotImplementedException();
        }
    }
}
