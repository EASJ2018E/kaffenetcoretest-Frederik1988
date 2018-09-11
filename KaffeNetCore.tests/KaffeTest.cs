using System;
using System.Collections.Generic;
using System.Text;
using kaffe;
using KaffeNetCore.kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.tests
{
    [TestClass]
    public class KaffeTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestMethodForMegetRabat35()
        {
            var sortKaffe = new SortKaffe(35);

            int pris = sortKaffe.Pris();
        }

        [TestMethod]
        public void TestMethodDefaultConstructorRabat()
        {
            
            var sortKaffe = new SortKaffe();

            
            sortKaffe.Pris();

            
            Assert.AreEqual(sortKaffe.Rabat, 0);

        }
        
    }
}
