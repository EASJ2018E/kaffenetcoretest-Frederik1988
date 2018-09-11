using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.tests
{
    [TestClass]
    public class MælkTest
    {
        [TestMethod]
        public void TestMethodLatteMælk()
        {
            var latte = new Latte();

            int mælk = latte.MlMælk();

            Assert.AreEqual(120, mælk);
        }

        [TestMethod]
        public void TestMethodFlatWhiteMælk()
        {
            var flatWhite = new FlatWhite();

            int mælk = flatWhite.MlMælk();

            Assert.AreEqual(160, mælk);
        }

        [TestMethod]

        public void TestMethodCortadoMælk()
        {
            var cortado = new Cortado();

            int mælk = cortado.MlMælk();

            Assert.AreEqual(25, mælk);
        }
    }
}
