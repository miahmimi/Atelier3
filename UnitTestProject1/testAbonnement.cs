using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class testAbonnement
    {
        [TestMethod]
        public void TestMethod1()
        {
            string id = "1234";
            DateTime date = DateTime.Now;
            string idRevue = "1111";
            Abonnement cmd = new Abonnement(id, date, idRevue);
            Assert.AreEqual(id, cmd.id);
            Assert.AreEqual(date, cmd.dateFinAbonnement);
        }
    }
}
