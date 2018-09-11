using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.tests
{
    [TestClass]
    public class PrisTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var latte = new Latte();

            int pris = latte.Pris();

            Assert.AreEqual(40,pris);
        }
    }
}
