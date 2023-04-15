using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MediaTekDocuments.model;

namespace UnitTestMediatekDoc
{
    [TestClass]
    public class UnitTest1
    {
        private const string id = "10010";
        private const string titre = "mon document";
        private const string image = "le lien vers image";
        private const string idGenre = "1001";
        private const string genre = "doc";
        private const string idPublic = "1002";
        private const string lePublic = "enfant";
        private const string idRayon = "1002";
        private const string rayon = "documents ";
        private static readonly Document doc = new Document(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon);

        

        /// <summary>
        ///tester le constructeur de la classe document
        ///
        /// </summary>

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(id, doc.Id, "Devrait reussir ");
            Assert.AreEqual(titre, doc.Titre, "Devrait reussir ");
            Assert.AreEqual(image, doc.Image, "Devrait reussir ");
            Assert.AreEqual(idGenre, doc.IdGenre, "Devrait reussir ");
            Assert.AreEqual(genre, doc.Genre, "Devrait reussir ");
            Assert.AreEqual(idPublic, doc.IdPublic, "Devrait reussir ");
            Assert.AreEqual(lePublic, doc.Public, "Devrait reussir ");
            Assert.AreEqual(idRayon, doc.IdRayon, "Devrait reussir ");
            Assert.AreEqual(rayon, doc.Rayon, "Devrait reussir ");
        }
    }
}
