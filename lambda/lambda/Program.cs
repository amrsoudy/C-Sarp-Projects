using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
        }
=======
using System.Windows.Forms;
using static Event.publisher;

namespace Event
{
    class Program
    {
        public static void Main(String[] args) {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Simulateur objSimulateur = Simulateur.GetInstance();
            Application.Run(objSimulateur);




        }
       

        




>>>>>>> 69cb9e5a9b5317418700e4ca4592801dc458e5d5
    }
}
