using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.tests
{
    [TestClass]
    public class PrisTest
    {
        [TestMethod]
        public void TestMethodLattePris()
        {
            var latte = new Latte();

            int pris = latte.Pris();

            Assert.AreEqual(40,pris);
        }
        [TestMethod]
        public void TestMethodCortadoPris()
        {
            var cortado = new Cortado();

            int pris = cortado.Pris();

            Assert.AreEqual(25, pris);
        }

        [TestMethod]

        public void TestMethodSortKaffePris()
        {
            var sortKaffe = new SortKaffe();

            int pris = sortKaffe.Pris();

            Assert.AreEqual(20, pris);
        }

        [TestMethod]

        public void TestMethodFlatWhite()
        {
            var flatWhite = new FlatWhite();

            int pris = flatWhite.Pris();

            Assert.AreEqual(45, pris);
        }
        
    }
}
