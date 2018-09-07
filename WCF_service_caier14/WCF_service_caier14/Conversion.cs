using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_service_caier14
{
    [DataContract]
    class Conversion
    {
        [DataMember]
        public String nom;
        [DataMember]
        public double valeur;
        [DataMember]
        public DateTime dateAppel;





    }
}
