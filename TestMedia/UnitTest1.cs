using NUnit.Framework;

namespace TestMedia
{
    public class Tests
    {
        private const string id = "1000";
        private const string titre = "mon document";
        private const string image = "le lien vers image";
        private const string idGenre = "1001";
        private const string genre = "doc";
        private const string idPublic = "1002";
        private const string lePublic = "enfant";
        private const string idRayon = "1002";
        private const string rayon = "documents ";
        private static readonly Document doc = new Document(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon);


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
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