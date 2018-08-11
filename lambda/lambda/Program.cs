using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
       

        




    }
}
