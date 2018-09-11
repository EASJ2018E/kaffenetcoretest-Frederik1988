using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace KaffeNetCore.tests
{
    [TestClass]
    public class FlatWhiteTest
    {
        [TestMethod]

        public void TestMethodFlatWhiteStyrke()
        {
            var flatWhite = new FlatWhite();

            string styrke = flatWhite.Styrke();

            Assert.AreEqual("Mild", styrke);

        }

        [TestMethod]
        public void TestMethodFlatWhiteMælk()
        {
            var flatWhite = new FlatWhite();

            int mælk = flatWhite.MlMælk();

            Assert.AreEqual(160, mælk);
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
