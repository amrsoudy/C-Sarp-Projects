using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSupDelegate
{
    class Utils
    {
        private static  Utils util;

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

        internal double calcul(int index)
        {
            double x;
            double y;


            double.TryParse(Form1.getInstance().textBox1.Text, out x);
            double.TryParse(Form1.getInstance().textBox2.Text, out y);



            double res = 0.0;

            if(index == 0)
            {
                
                res= x + y;


            }
            else if (index == 1)
            {

                res = x - y;


            }
            return res;
        }
    }
}
