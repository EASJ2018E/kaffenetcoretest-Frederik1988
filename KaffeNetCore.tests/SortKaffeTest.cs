
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.tests
{
    [TestClass]
    public class SortKaffeTest
    {
        [TestMethod]

        public void TestMethodSortKaffePris()
        {
            var sortKaffe = new SortKaffe();

            int pris = sortKaffe.Pris();

            Assert.AreEqual(20, pris);
        }

        [TestMethod]

        public void TestMethodSortKaffeStyrke()
        {
            var sortKaffe = new SortKaffe();

            string styrke = sortKaffe.Styrke();

            Assert.AreEqual("stærk", styrke);
        }
    }
}
