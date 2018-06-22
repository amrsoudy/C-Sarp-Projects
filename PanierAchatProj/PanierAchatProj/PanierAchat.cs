using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanierAchatProj
{
    class PanierAchat
    {
        private String _nom;
        public String Nom { get; set; }

        private string _noItem;
        private string _nomItem;
        private string _tailleItem;
        private Decimal _prixItem;

        public string codeItem { get { return _noItem;}  set { _noItem = value; } }
        public String nameItem { get { return _nomItem; } set { _nomItem = value; } }
        public string taillItem { get { return _tailleItem; } set { _tailleItem = value; } }

        public Decimal priceItem { get { return _prixItem; } set { _prixItem = value; } }

        public PanierAchat(string noItem,string nomItem,string tailleItem,Decimal prixItem)
        {

            codeItem = noItem;
            nameItem = nomItem;
            taillItem = tailleItem;
            priceItem = prixItem;

        }

    }
}
