
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.tests
{
    [TestClass]
    public class CortadoTest
    {
        [TestMethod]

        public void TestMethodCortadoMælk()
        {
            var cortado = new Cortado();

            int mælk = cortado.MlMælk();

            Assert.AreEqual(25, mælk);
        }

        [TestMethod]
        public void TestMethodCortadoPris()
        {
            var cortado = new Cortado();

            int pris = cortado.Pris();

            Assert.AreEqual(25, pris);
        }
    }
}
