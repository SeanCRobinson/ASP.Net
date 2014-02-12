using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWeb.Business
{
    public class WeightConvert
    {
        public double Pounds2Ounces(double pounds)
        {
            double ounces = pounds * 16;
            return ounces;
        }
        public double Ounces2Pounds(double ounces)
        {
            double pounds = ounces / 16;
            return pounds;
        }
    }
}
