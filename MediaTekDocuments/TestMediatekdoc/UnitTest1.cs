using NUnit.Framework;
using mediaTekDocument.model;
using System;

namespace TestMediatekdoc
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string id = "1234";
            DateTime date = DateTime.Now();
            string montant = "1111";
            Commande cmd = new Commande(id,date,montant);
            Assert.AreEqual(id, commande.id);


        }
    }
}