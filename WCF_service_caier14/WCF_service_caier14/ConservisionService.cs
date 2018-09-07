using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_service_caier14
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class ConservisionService : IconversionService
    {
        #region IConversionService Memberes
        public double ConvertVersCelsius(double temp)
        {

            return (temp - 32) / 2.0;

        }

        public double ConvertVersFahr(double temp)
        {

            return (2.0 * temp + 32);
        }

        #endregion
    }
}
