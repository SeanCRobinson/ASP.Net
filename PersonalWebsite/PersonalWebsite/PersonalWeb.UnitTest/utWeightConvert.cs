using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalWeb.Business;

namespace PersonalWeb.UnitTest
{
    [TestClass]
    public class utWeightConvert
    {
        [TestMethod]
        public void TestPounds2OuncesPass()
        {
            WeightConvert wtConverter = new WeightConvert();
            double TotalPounds = wtConverter.Ounces2Pounds(16);
            Assert.AreEqual(1, TotalPounds);

            TotalPounds = wtConverter.Ounces2Pounds(88);
            Assert.AreEqual(5.5, TotalPounds);

            TotalPounds = wtConverter.Ounces2Pounds(0);
            Assert.AreEqual(0, TotalPounds);
        }

        [TestMethod]
        public void TestPounds2OuncesFail()
        {
            WeightConvert wtConverter = new WeightConvert();
            double TotalPounds = wtConverter.Ounces2Pounds(16);
            Assert.AreNotEqual(16, TotalPounds);
        }
    }
}
