using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManipulation
{
    class Utils
    {
        private Utils utils;

        public Utils getInstance() {


            if (utils == null)
            {

                utils = new Utils();
                return utils;
            }
            else {

                return utils;

            }

        }
    }
}
