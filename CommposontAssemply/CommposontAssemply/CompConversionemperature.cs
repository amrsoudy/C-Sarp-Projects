using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommposontAssemply
{
    public class CompConversionemperature
    {

        public double ConversionCelsiusToFahr(double Celsius)
        {


            return (int)((Celsius * 9 )/ 5.0 + 32);

        }
        public double ConversionFahrToCels(double Fah)
        {


            return (int)((Fah-32) * 5 /9.0 );

        }
    }
}
