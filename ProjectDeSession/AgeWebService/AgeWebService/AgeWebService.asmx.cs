using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Services;

namespace AgeWebService
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
        public String Verifier(int X)
        {
            String s = "";

            try
            {

                if (X <= 1970)
                {
                    s = " il est le temp d.aller se promener a travers le monde ";

                }
                else if (X >= 1971 && X <= 1980)
                {

                    s = "il est temps de commencer a travailler sérieusement";
                }
                else if (X >= 1981 && X <= 1990)
                {

                    s = "il est grand temps de terminer tes études !";
                }
                else if (X >= 1991 && X <= 2000)
                {

                    s = "Faire ce qui te plait ; ti as encoure le temps !";
                }
                else if (X >= 2001 && X <= 2010)
                {

                    s = "Utilisation de service non autorisee!";
                }





            }
            catch (Exception ex)
            {

                



            }
         
            GetRequestHeaders();
            return s ;
            

        }

      
        public void GetRequestHeaders()
        {
            //HttpContext ctx = HttpContext.Current;
            //if (ctx == null || ctx.Request == null || ctx.Request.Headers == null)
            //{
            //    return string.Empty;
            //}
            //string headers = string.Empty;
            //foreach (string header in ctx.Request.Headers.AllKeys)
            //{
            //    string[] values = ctx.Request.Headers.GetValues(header);
            //    headers += string.Format("{0}: {1}", header, string.Join(",", values));
            //}

//------------------------------------------------------------------------------------------------

            HttpContext ctx = HttpContext.Current;
            //if (ctx == null || ctx.Request == null || ctx.Request.Headers == null)
            //{
            //    return string.Empty;
            //}
            string headers = string.Empty;
            String NameMachineUser = ctx.Request.LogonUserIdentity.Name;
            DateTime dateTime = DateTime.Now;

            String[] sp = NameMachineUser.Split('\\');
            String username = sp[1];
            String machineName = sp[0];

           

            String s = machineName + "," + username + "," + dateTime;


           
        }
    }
}
