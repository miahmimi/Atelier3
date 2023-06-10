using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class testEtape
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string id = "2";
            etape e = new etape(id);
            Assert.AreEqual(id, e.idetape);
        }
    }
}
