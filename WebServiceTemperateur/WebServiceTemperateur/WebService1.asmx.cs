using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceTemperateur
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        [WebMethod]
        public double Calcultemp(double a, String type ,out String msg)
        {
            double c = 0;

            if (type.Equals("c"))
            {

                c = (a - 32) / 2;

            }
            else
            {

                c = a;
            }



            if (c >= 25)
            {

                msg = "natation";
            }
            else if (c >= 18 && c < 25)
            {

                msg = "tennis";
            }
            else if (c < 18 && c >= 2)
            {

                msg = "randonnes dans les bois ";

            }
            else if (c < 2)
            {

                msg = "ski ";

            }
            else {

                msg = " ce pas  bon  number ";
            }

            
            return c;






        }

    }
}
