using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KaffeNetCore.tests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethodProgramTest()
        {
            //Arrange
            KaffeNetCore.Program.Main();
            var c = KaffeNetCore.Program.IsRunning;

            //Act
            bool test = true;

            //Assert
            Assert.AreEqual(c, test);
        }
    }
    
}
