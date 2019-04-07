using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTest
{
    [TestClass]
    public class MyArithTests
    {
        [TestMethod]
        public void TestOutputPrinterWithCapsLockString()
        {
            //arrange
            string word = "PROGRAM";
            //act
            ArithmeticCoding.Output.Printer(word);
            //assert
            Assert
        }
    }
}
