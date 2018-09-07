using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_service_caier14
{

    [ServiceContract]
    public interface IconversionService
    {
        [OperationContract]
        double ConvertVersCelsius(double temp);
        [OperationContract]
        double ConvertVersFahr(double temp);

    }
}
