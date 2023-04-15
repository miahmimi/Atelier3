using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMediatekDoc
{
    [TestClass]
    public class Test_categorie
    {
        private const string idcategorie = "1";
        private const string libelle = "Ados ";
        private static readonly Categorie c = new Categorie(idcategorie, libelle);

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(idcategorie, c.Id, "Devrait  reussir ");
            Assert.AreEqual(libelle, c.Libelle, "Devrait reussir ");

        }
    }
}
