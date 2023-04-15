using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMediatekDoc
{
    [TestClass]
    public class Test_Livre
    {
        

        private const string id = "1";
        private const string titre = "Ados ";
        private const string image = "Ados ";
        private const string isbn = "Ados ";
        private const string auteur = "Ados ";
        private const string collection = "Ados ";
        private const string idGenre = "Ados ";
        private const string genre = "Ados ";
        private const string idPublic = "Ados ";
        private const string lePublic = "Ados ";
        private const string idRayon = "Ados ";
        private const string rayon = "Ados ";
        
        private static readonly Livre v = new Livre(id, titre,image,isbn,auteur,collection,idGenre,genre,idPublic,lePublic,idRayon,rayon);

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(id, v.Id, "Devrait reussir ");
            Assert.AreEqual(titre, v.Titre, "Devrait reussir ");
            Assert.AreEqual(image, v.Image, "Devrait reussir ");
            Assert.AreEqual(isbn, v.Isbn, "Devrait reussir ");
            Assert.AreEqual(auteur, v.Auteur, "Devrait reussir ");
            Assert.AreEqual(collection, v.Collection, "Devrait reussir ");
            Assert.AreEqual(idGenre, v.IdGenre, "Devrait reussir ");
            Assert.AreEqual(genre, v.Genre, "Devrait reussir ");
            Assert.AreEqual(idPublic,v.IdPublic, "Devrait reussir ");
            Assert.AreEqual(lePublic, v.Public, "Devrait reussir ");
            Assert.AreEqual(idRayon,v.IdRayon, "Devrait reussir ");
            Assert.AreEqual(rayon, v.Rayon, "Devrait reussir ");
        }
    }
}
