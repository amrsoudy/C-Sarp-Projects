using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AgeWebService
{
    /// <summary>
    /// Description résumée de ErrorService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceBD : System.Web.Services.WebService
    {

        [WebMethod]
        public void sauvgarderBD(String s) {


            String[] listStr = s.Split(',');

            String machineName = listStr[0];
            String userName = listStr[1];
            String dateTime = listStr[2];







        }
        


    }
}
