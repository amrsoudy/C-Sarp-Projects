using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cah1_manip2
{
    [DefaultProperty("nomContact")]
    public class ContactComponent :Component

    {
        private String m_nomContact;
        private String m_typeContact;
        private String m_telContact;
        [Browsable(true), Category("Properties"), Description("Identifi le nom du contact")]

        public String NomContact
        {

            get { return m_nomContact; }
            set { m_nomContact = value; }

        }
        [Browsable(true), Category("Properties"), Description("Identifi le nom du Contact")]

        public String TypeContact
        {

            get { return m_typeContact; }
            set { m_typeContact = value; }

        }
        [Browsable(true), Category("Properties"), Description("Identifie le telephone du contact")]
        public string TelephoneContact
        {
            get { return m_telContact; }
            set { m_telContact = value; }
        }

        public ContactComponent()
        {
            this.NomContact = "Une exemple de contact";
            this.TypeContact = "Professionnel";
            this.TelephoneContact = "514-555-5555";
        }
        //Defaut constructeur
        public ContactComponent(string nomContact, string typeContact, string telContact)
        {
            this.NomContact = nomContact;
            this.TypeContact = typeContact;
            this.TelephoneContact = telContact;
        }


    }
}
