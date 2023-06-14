using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConversionTest
{
    [TestClass]
    public class UnitTest1
    {
        Conversion.ConversionNumbers convert = new Conversion.ConversionNumbers(); 

        [TestMethod]
        public void ConvertConversionFrom10_2_and_15_return_1111()
        {
            string actual = convert.ConversionFrom10(2, 15),
                   expected = "1111";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertConversionFrom10_8_and_15_return_17()
        {
            string actual = convert.ConversionFrom10(8, 15),
                   expected = "17";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertConversionFrom10_16_and_15_return_F()
        {
            string actual = convert.ConversionFrom10(16, 15),
                   expected = "f";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertConversionFrom10_20_and_15_return_error()
        {
            string actual = convert.ConversionFrom10(20, 15),
                   expected = "Данная система счисления не существует";

            Assert.AreEqual(expected, actual);
        }
    }
}
