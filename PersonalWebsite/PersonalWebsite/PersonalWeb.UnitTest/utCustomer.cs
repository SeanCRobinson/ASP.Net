using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalWeb.Business;

namespace PersonalWeb.UnitTest
{
    [TestClass]
    public class utCustomer
    {
        [TestMethod]
        public void GetCustomerFullNameByID()
        {
            Customer objCustomer = new Customer();
            string TestReturn = objCustomer.GetCustomerFullNamE(1);
            Assert.AreEqual("Winston Payne", TestReturn);
        }
        [TestMethod]
        public void GetCustomerFullNameByIDFail()
        {
            Customer objCustomer = new Customer();
            string TestReturn = objCustomer.GetCustomerFullNamE(-1);
            Assert.AreEqual("Winston Payne", TestReturn);
        }
    }
}
