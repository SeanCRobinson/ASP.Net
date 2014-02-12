using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace PersonalWeb.Business
{
    public class Customer
    {
        public string GetCustomerFullNamE(int CustomerID)
        {
            dlCustomer CustomerData = new dlCustomer();
            return CustomerData.GetCustomerFullName(CustomerID);
        }
    }
}
