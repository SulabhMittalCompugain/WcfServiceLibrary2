using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IService1 wcfserv = new WcfServiceLibrary1.Service1();

            Assert.AreEqual(wcfserv.GetData(2), "You entered: 2");
        }
    }
}
