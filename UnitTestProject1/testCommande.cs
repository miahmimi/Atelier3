using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MediaTekDocuments.model;

namespace UnitTestProject1
{
    [TestClass]
    public class testCommande
    {
        [TestMethod]
        public void TestMethod1()
        {
            string id = "1234";
            DateTime date = DateTime. Now;
            string montant = "1111";
            Commande cmd = new Commande(id, date, montant);
            Assert.AreEqual(id, cmd.id);
        }
    }
}
