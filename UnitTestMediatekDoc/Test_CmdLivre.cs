using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMediatekDoc
{
    [TestClass]
    public class Test_CmdLivre
    {
        
        private const string etape="2";
        private const int qte =100;
        private const string idarticle ="3";
        private static DateTime dateCommande =new  DateTime(2023,02,01);
        private const int montant = 200;
        private const string id = "20";


        private static readonly CmdLivre cmd = new CmdLivre(etape, qte, idarticle,id, dateCommande,montant);
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(etape, cmd.Etape, "Devrait reussir ");
            Assert.AreEqual(qte, cmd.Quantité, "Devrait reussir ");
            Assert.AreEqual(idarticle, cmd.idArticle, "Devrait reussir ");
        }
    }
}
