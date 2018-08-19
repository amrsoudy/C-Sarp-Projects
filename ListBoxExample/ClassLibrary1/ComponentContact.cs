using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [DefaultProperty("nomContact")]

    // on doit fair public    et  il hirite de component 
    public class  ComponentContact : Component
    {
        private String m_nomcontact ;
        private String m_typeContact;
        private String m_telephoe; 

        //Browsable  pour afficher dan la probirties 
        //categorie  pour grouper la fonctions 
        //description pour afficher description 
        // Defautl probertie  

        [Browsable(true),Category("Properties"),Description("Identification de nom contact")]
        public String Nomcontact {
            get { return m_nomcontact; }
            set { m_nomcontact = value;  }



        }
        [Browsable(true), Category("Properties"), Description("Identification de type contact")]
        public String TypeContact
        {
            get { return m_typeContact; }
            set { m_typeContact = value; }



        }
        [Browsable(true), Category("Properties"), Description("Identification de tel contact")]
        public String Tel
        {
            get { return m_telephoe; }
            set { m_telephoe = value; }



        }

        public ComponentContact() {

            Nomcontact = "Amr Seoudy";
            TypeContact = "number 1";
            Tel = "5144582728";


        }

        public ComponentContact(string m_nomcontact, string m_typeContact, string m_telephoe)
        {
            this.m_nomcontact = m_nomcontact;
            this.m_typeContact = m_typeContact;
            this.m_telephoe = m_telephoe;
        }
    }
}
