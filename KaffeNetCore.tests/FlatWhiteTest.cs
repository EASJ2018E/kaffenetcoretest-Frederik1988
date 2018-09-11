using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace KaffeNetCore.tests
{
    [TestClass]
    public class StyrkeTest
    {
        [TestMethod]

        public void TestMethodFlatWhiteStyrke()
        {
            var flatWhite = new FlatWhite();

            string styrke = flatWhite.Styrke();

            Assert.AreEqual("Mild", styrke);

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
