using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.tests
{
    [TestClass]
    public class LatteTest
    {
        [TestMethod]
        public void TestMethodLatteMælk()
        {
            var latte = new Latte();

            int mælk = latte.MlMælk();

            Assert.AreEqual(120, mælk);
        }

        [TestMethod]
        public void TestMethodLattePris()
        {
            var latte = new Latte();

            int pris = latte.Pris();

            Assert.AreEqual(40, pris);
        }


    }
}
